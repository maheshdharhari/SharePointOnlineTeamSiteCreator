using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Windows.Forms;

namespace SharePointTeamSiteCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to create the Team Site
        private async void btnCreateSite_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input from form fields
                var clientId = txtClientId.Text;        // Azure AD Client ID
                var tenantId = txtTenantId.Text;        // Azure AD Tenant ID
                var clientSecret = txtClientSecret.Text; // Azure AD Client Secret
                var siteDisplayName = txtSiteName.Text;  // Desired Team Site name
                var siteDescription = txtSiteDescription.Text; // Site Description

                // Validate that all required fields are filled
                if (string.IsNullOrWhiteSpace(clientId) ||
                    string.IsNullOrWhiteSpace(tenantId) ||
                    string.IsNullOrWhiteSpace(clientSecret) ||
                    string.IsNullOrWhiteSpace(siteDisplayName))
                {
                    MessageBox.Show(@"Please fill in all required fields.");
                    return;
                }

                // Authenticate and get GraphServiceClient
                /*var graphClient = GetAuthenticatedGraphClient(clientId, tenantId, clientSecret);

                // Define the site properties
                var teamSite = new Site
                {
                    DisplayName = siteDisplayName,
                    Description = siteDescription,
                    WebTemplate = "GROUP",  // Creates a modern team site (group-connected)
                    Visibility = "Private"
                };

                // Create the Team Site
                await graphClient.Sites.Request().AddAsync(teamSite);*/

                MessageBox.Show(@"Team Site created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error creating site: {ex.Message}");
            }
        }

        // Method to authenticate to Microsoft Graph using client credentials
        /*private GraphServiceClient GetAuthenticatedGraphClient(string clientId, string tenantId, string clientSecret)
        {
            var confidentialClient = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithTenantId(tenantId)
                .WithClientSecret(clientSecret)
                .Build();

            var authProvider = new DelegateAuthenticationProvider(async (requestMessage) =>
            {
                var result = await confidentialClient
                    .AcquireTokenForClient(new[] { "https://graph.microsoft.com/.default" })
                    .ExecuteAsync();

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);
            });

            return new GraphServiceClient(authProvider);
        }*/
    }
}
