using System;
using Form = System.Windows.Forms.Form;


namespace SharePointTeamSiteCreator
{
    /// <summary>
    /// The main form for creating SharePoint Online Classic Team Sites using C# and WinForms.
    /// This form collects user inputs such as the Admin Site URL, Tenant ID, Client ID, 
    /// Site Name, Site Owner, and Site Description, and triggers the site creation process
    /// by calling the SharePointUtils class.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constant representing the template for a SharePoint Classic Team Site (STS#0).
        /// </summary>
        private const string SiteTemplate = "STS#0";

        /// <summary>
        /// Constant representing the language locale ID for English (1033).
        /// </summary>
        private const uint SiteLanguage = 1033;

        /// <summary>
        /// Constant representing the storage quota in MB for the new site.
        /// </summary>
        private const int SiteStorageQuota = 1000;

        /// <summary>
        /// Constant representing the user code quota for the new site (usually 0 unless required).
        /// </summary>
        private const int SiteUserCodeQuota = 0;

        /// <summary>
        /// Initializes a new instance of the Form1 class and sets up the form components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event handler that triggers the site creation process.
        /// Gathers user input from form fields and passes it to the SharePointUtils.CreateTeamSiteAuthentication method.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments.</param>
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
            await SharePointUtils.CreateTeamSiteAuthentication(adminSiteUrl, tenantId, clientId, SiteStorageQuota,
                SiteUserCodeQuota, siteDisplayName, siteOwner, siteUrl, SiteTemplate, SiteLanguage);
        }
    }
}