# CURD_OPERATIONS

This is an ASP.NET Web Forms project demonstrating basic CRUD operations and data display using dropdown lists.

## 📁 Project Structure

- **CURD_OPERATION_WebForm1.aspx**  
  Handles Create, Update, Read, and Delete operations using ADO.NET and SQL Server.

- **Display_Data_Using_DropdownList.aspx**  
  Demonstrates how to retrieve and display data based on user selection from cascading dropdown lists (e.g., State → City).

- **Default.aspx**  
  Serves as the homepage or main landing page of the application.

- **About.aspx / Contact.aspx**  
  Static pages with information about the application.

- **Global.asax**  
  Application-level event handler (e.g., session start, error handling).

- **Site.Master / Site.Mobile.Master**  
  Master pages for desktop and mobile layout consistency.

- **App_Data**  
  Intended to store the SQL database files (if used locally).

- **Scripts / Content**  
  Stores JavaScript, CSS, and static assets.

## 🧪 Features

- Perform CRUD (Create, Read, Update, Delete) operations.
- Cascading dropdown functionality for dynamic data filtering.
- SQL Server database connectivity using ADO.NET.
- GridView integration for displaying tabular data.
- Modular code separation in `.aspx.cs` and `.designer.cs`.

## ⚙️ Technologies Used

- ASP.NET Web Forms
- C#
- ADO.NET
- SQL Server
- HTML/CSS
- Visual Studio

## 🚀 Getting Started

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Configure your SQL Server connection string in `Web.config`.
4. Run the project using IIS Express or your preferred server.

## 📄 Configuration

Update your SQL Server connection string in `Web.config`:

```xml
<connectionStrings>
  <add name="karthik" 
       connectionString="Data Source=.;Initial Catalog=kiran;Integrated Security=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
