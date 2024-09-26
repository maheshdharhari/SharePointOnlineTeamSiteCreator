using System;
using Form = System.Windows.Forms.Form;


namespace SharePointTeamSiteCreator
{
    public partial class Form1 : Form
    {
        private const string SiteTemplate = "STS#0"; // STS#0 is the template for a classic team site
        private const uint SiteLanguage = 1033; // English
        private const int SiteStorageQuota = 1000; // Storage quota in MB
        private const int SiteUserCodeQuota = 0; // User code quota (usually 0 unless required)

        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to create the Team Site
        private async void btnCreateSite_Click(object sender, EventArgs e)
        {
            // Get user input from form fields
            var adminSiteUrl = txtAdminSiteUrl.Text; // Tenant admin url
            var tenantId = txtTenantId.Text; // Azure AD Tenant ID
            var clientId = txtClientId.Text; // Azure AD Client ID
            var siteDisplayName = txtSiteDisplayName.Text; // Desired Team Site name
            var siteOwner = textSiteOwner.Text; // Desired Team Site name
            var siteDescription = txtSiteDescription.Text; // Site Description
            var siteUrl = adminSiteUrl.Replace("-admin", null) + "/sites/" +
                          siteDisplayName.Replace(" ", string.Empty).ToLower();
            await SharePointUtils.CreateTeamSiteAuthentication(adminSiteUrl, tenantId, clientId, SiteStorageQuota, SiteUserCodeQuota, siteDisplayName, siteOwner, siteUrl, SiteTemplate, SiteLanguage);
        }
    }
}