using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.Identity.Client;

namespace SharePointTeamSiteCreator
{
    /// <summary>
    /// Utility class that provides methods for SharePoint Online site creation using the Client-Side Object Model (CSOM)
    /// and Multi-Factor Authentication (MFA) via Microsoft Authentication Library (MSAL).
    /// </summary>
    internal static class SharePointUtils
    {
        /// <summary>
        /// Creates a new SharePoint Online Classic Team Site using Client-Side Object Model (CSOM) and MFA.
        /// The method uses Microsoft Identity Client (MSAL) for authentication and creates the site using the 
        /// Tenant administration API.
        /// </summary>
        /// <param name="adminSiteUrl">The SharePoint Online admin site URL.</param>
        /// <param name="tenantId">The Azure Active Directory Tenant ID.</param>
        /// <param name="clientId">The Azure AD app registration Client ID.</param>
        /// <param name="siteStorageQuota">The storage quota in MB for the new site.</param>
        /// <param name="siteUserCodeQuota">The user code quota for the new site.</param>
        /// <param name="siteTitle">The title for the new SharePoint site.</param>
        /// <param name="siteOwner">The owner of the new SharePoint site.</param>
        /// <param name="siteUrl">The URL for the new SharePoint site.</param>
        /// <param name="template">The template for the site (e.g., STS#0 for a classic team site).</param>
        /// <param name="siteLanguage">The language locale ID for the site (default is 1033 for English).</param>
        /// <returns>A Task representing the asynchronous site creation operation.</returns>
        internal static async Task CreateTeamSiteAuthentication(string adminSiteUrl, string tenantId, string clientId,
            long siteStorageQuota, long siteUserCodeQuota,
            string siteTitle, string siteOwner,
            string siteUrl,
            string template = "STS#0", uint siteLanguage = 1033)
        {
            var scopes = new string[] { adminSiteUrl + "/.default" }; // Scopes


            var app = GetPublicClientApp(tenantId, clientId);
            AuthenticationResult authResult = null;
            try
            {
                // Use interactive authentication to sign in
                authResult = await app.AcquireTokenInteractive(scopes)
                    .ExecuteAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error acquiring token: " + ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Access token retrieved
            var accessToken = authResult.AccessToken;

            try
            {
                // Create a new ClientContext using the access token for MFA
                using (var clientContext = new ClientContext(adminSiteUrl))
                {
                    clientContext.ExecutingWebRequest += (sender, webRequestEventArgs) =>
                    {
                        webRequestEventArgs.WebRequestExecutor.RequestHeaders["Authorization"] =
                            "Bearer " + accessToken;
                    };

                    // Tenant object to manage site creation
                    var tenant = new Tenant(clientContext);

                    var siteCreationInfo = new SiteCreationProperties
                    {
                        Url = siteUrl,
                        Title = siteTitle,
                        Lcid = siteLanguage, // Locale ID for English
                        Template = template, // Web Template for classic team site
                        Owner = siteOwner,
                        StorageMaximumLevel = siteStorageQuota,
                        UserCodeMaximumLevel = siteUserCodeQuota
                    };

                    var spoOperation = tenant.CreateSite(siteCreationInfo);
                    clientContext.Load(spoOperation);
                    clientContext.ExecuteQuery();

                    MessageBox.Show(@"Site has been created successfully.", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configures and returns a PublicClientApplication object for MSAL authentication.
        /// This method sets the authority and client ID for authentication.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory Tenant ID.</param>
        /// <param name="clientId">The Azure AD app registration Client ID.</param>
        /// <returns>An IPublicClientApplication object used for acquiring authentication tokens.</returns>
        private static IPublicClientApplication GetPublicClientApp(string tenantId, string clientId)
        {
            try
            {
                var tenant = string.IsNullOrEmpty(tenantId) ? "common" : tenantId;
                var authorityUri = $"https://login.microsoftonline.com/{tenant}";
                var clientApp = PublicClientApplicationBuilder.Create(clientId)
                    .WithAuthority(authorityUri)
                    .WithDefaultRedirectUri()
                    .Build();
                return clientApp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }
    }
}