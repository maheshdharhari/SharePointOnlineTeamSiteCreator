# SharePoint Team Site Creator using C# WinForms

This project demonstrates how to create a **Team Site** in **SharePoint Online** using a **C# WinForms application**. By leveraging the **Microsoft Graph API** and authenticating via **Azure AD**, users can easily create modern team sites with dynamic input for credentials and site details.

## Features
- Create a **Team Site** in **SharePoint Online**.
- User-friendly **WinForms** UI for inputting **Azure AD** credentials and site information.
- Uses **Microsoft Graph API** for site creation.
- **Azure AD Client Credentials Flow** for authentication.

## Prerequisites
1. **Azure AD App Registration**:
   - Create an app in **Azure AD** with **Sites.FullControl.All** permissions.
   - Obtain the **Client ID**, **Tenant ID**, and **Client Secret** for use in the application.
   
2. **Visual Studio**:
   - Ensure **.NET Framework** is installed with **Windows Forms App** components.

3. **NuGet Packages**:
   - Install the following packages in the project:
     - `Microsoft.Graph`
     - `Microsoft.Identity.Client`

## How to Run
1. Clone this repository to your local machine.
2. Open the solution in **Visual Studio**.
3. Install the required **NuGet packages** (`Microsoft.Graph`, `Microsoft.Identity.Client`).
4. Build the project and run it.
5. Enter the **Azure AD** credentials (Client ID, Tenant ID, Client Secret) and the desired **Team Site** details in the form.
6. Click "Create Team Site" to create the site in **SharePoint Online**.

## Form Layout
The form allows the user to input:
- **Client ID** (Azure AD Client ID)
- **Tenant ID** (Azure AD Tenant ID)
- **Client Secret** (Azure AD Client Secret)
- **Team Site Name**
- **Team Site Description**

## How it Works
- The application authenticates via the **Azure AD Client Credentials Flow**.
- Using the **Microsoft Graph API**, it sends a request to create a **Team Site** with the provided information.
- The user is notified once the site has been successfully created.

## Screenshots

![WinForms](https://res.cloudinary.com/maheshdharhari/image/upload/v1727165770/Blog/SharePointTeamSiteCreatorProject.png)

### Form Interface
```
Client ID:         [ txtClientId ]
Tenant ID:         [ txtTenantId ]
Client Secret:     [ txtClientSecret ]
Site Name:         [ txtSiteName ]
Site Description:  [ txtSiteDescription ]
                  [ Create Team Site Button ]
```

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.