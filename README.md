# SharePoint Online Classic Team Site Creator with MFA

This project demonstrates how to create SharePoint Online Classic Team Sites using **C#** and **WinForms** with **Multi-Factor Authentication (MFA)** integration. The application leverages **Microsoft Authentication Library (MSAL)** for secure authentication and **Client-Side Object Model (CSOM)** for site creation.

![Running Project](https://res.cloudinary.com/maheshdharhari/image/upload/v1727340937/Blog/SharePointTeamSiteCreator.png "Running Project")

## Features
- **WinForms Interface**: Allows users to enter site details (Admin URL, Tenant ID, Client ID, Site Name, etc.) via a simple GUI.
- **Multi-Factor Authentication (MFA)**: Uses MSAL to enable secure MFA during login.
- **SharePoint Classic Team Site Creation**: Creates classic team sites using CSOM with the `STS#0` template.
- **Status Tracking**: Polls the server to check the status of site creation until the process completes.

## Prerequisites
- Visual Studio (for building the project)
- An Azure Active Directory app registration with the necessary permissions for SharePoint Online.
- Installed NuGet packages:
  - `Microsoft.SharePointOnline.CSOM`
  - `Microsoft.Identity.Client (MSAL)`

## How to Use
1. Clone or download this repository.
2. Open the solution in **Visual Studio**.
3. Build the project to restore the required NuGet packages.
4. Run the application and enter the necessary details:
   - **Admin Site URL**: The admin URL of your SharePoint tenant.
   - **Tenant ID**: Your Azure AD tenant ID.
   - **Client ID**: Your Azure AD app registration client ID.
   - **Site Name**: The desired name for your team site.
   - **Site Owner**: The email address of the site owner.
   - **Site Description**: A brief description of the team site.
5. Click **Create Team Site** to start the process. You will be prompted to authenticate, including MFA.
6. The application will notify you once the site is created successfully.

## Authentication
This project uses **Microsoft Authentication Library (MSAL)** to handle Multi-Factor Authentication. Users are required to authenticate interactively to acquire an access token, which is used for CSOM API calls.

## Dependencies
- [Microsoft.SharePointOnline.CSOM](https://www.nuget.org/packages/Microsoft.SharePointOnline.CSOM/)
- [Microsoft.Identity.Client (MSAL)](https://www.nuget.org/packages/Microsoft.Identity.Client/)

## License
This project is licensed under the MIT License. 

## Author
This is created by [Mahesh Kumar Yadav](contact@maheshyadav.com.np).

## Contributions
Contributions are welcome! Feel free to submit a pull request or open an issue for any improvements or bug fixes.
