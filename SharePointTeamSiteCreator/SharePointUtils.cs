using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.Identity.Client;

namespace SharePointTeamSiteCreator
{
    internal static class SharePointUtils
    {
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
                    // Check the operation status
                    while (!spoOperation.IsComplete)
                    {
                        MessageBox.Show(@"Creating site... Please wait", Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        System.Threading.Thread.Sleep(30000); // Wait for 30 seconds
                        spoOperation.RefreshLoad();
                        clientContext.ExecuteQuery();
                    }

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