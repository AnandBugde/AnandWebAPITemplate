Creating a Visual Studio 2022 Project Template that includes Pagination for a Web API, Fixed API Token Validation using a Required header parameter, Custom Logging, and AppSettings with Virtual Directory setup for IIS involves several steps. Below is a point-wise explanation:

**Project Template Structure:**

Begin by creating a new project in Visual Studio 2022.
Organize your project with folders for controllers, services, models, etc.

**Pagination for Web API:**

Implement pagination logic in your controllers or services.
Create a base controller or middleware that handles pagination to keep the code DRY (Don't Repeat Yourself).
Include sample API methods that demonstrate pagination with query parameters like page and pageSize.

**Fixed API Token Validation:**

Implement a custom authentication attribute or middleware that validates the API token.
Use the [Authorize] attribute on your controllers or actions.
Ensure that the API token is sent in the required header parameter (e.g., Authorization header).

**Custom Logging:**

Integrate a logging library like Serilog or NLog into your project.
Set up loggers in your controllers, services, or other components where logging is necessary.
Customize log levels, log formats, and output sinks as needed.

**AppSettings Configuration:**

Create an appsettings.json file to store configuration settings.
Add sections for database connections, API tokens, or any other configurable settings.
Load these settings using the Configuration API in your application.

**Virtual Directory Setup for IIS:**

Configure your project to work under a virtual directory in IIS.
Update your project's properties to include the necessary settings for virtual directory deployment.
Adjust routing and configuration to account for the virtual directory path.

**Common Code Implementation:**

Identify common functionality or utilities that are shared across your application.
Move this code into a separate project or folder within your solution to create a reusable library.
Ensure that your Project Template references this common code so that it is included when new projects are created based on the template.

**Creating the Project Template:**

In Visual Studio, go to File > Export Template.
Choose "Project Template" and follow the wizard, providing necessary metadata.
Include all the necessary files, configurations, and dependencies in the template.
Save the template.

**Usage in Visual Studio 2022:**
Install the project template in Visual Studio.
Create a new project using the template.
Customize the generated project based on your specific requirements.
By following these steps, you can create a Visual Studio 2022 Project Template that includes common features such as pagination, API token validation, custom logging, app settings, and IIS virtual directory setup, with the advantage of reusing common code across multiple projects.


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## Features

- **Modular Project Structure:** Organized folders for controllers, services, models, and common utilities.
- **Pagination Support:** Efficiently handle large data sets with built-in pagination logic and helper classes.
- **API Token Validation:** Secure your APIs with required token validation using custom authentication middleware and header parameters.
- **Custom Logging:** Integrated logging with support for popular libraries like Serilog or NLog, customizable for your needs.
- **AppSettings Configuration:** Centralized configuration with `appsettings.json` for database connections, tokens, and other settings.
- **IIS Virtual Directory Ready:** Easily deploy under a virtual directory with proper routing and configuration out-of-the-box.
- **Reusable Common Code:** Utility classes and shared logic centralized for maintainability.

---

## Getting Started

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or later)
- [.NET SDK](https://dotnet.microsoft.com/download)

### Clone the Repository

```bash
git clone https://github.com/AnandBugde/AnandWebAPITemplate.git
cd AnandWebAPITemplate
```

### Installation & Setup

1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Build the project.

### Running the API

```bash
dotnet run
```
The API will be available at `http://localhost:5000` (or as configured).

---

## Usage

- **Pagination:** Use query parameters like `page` and `pageSize` on your endpoints to paginate data.
- **API Token:** Pass your token in the required header (e.g., `Authorization`) for secured endpoints.
- **Logging:** Check configured output (console, file, etc.) for custom log entries.
- **AppSettings:** Modify `appsettings.json` for environment variables, connection strings, and more.

---

## Project Template Structure

- **Controllers:** API endpoints
- **Services:** Business logic
- **Models:** Data structures and DTOs
- **Common:** Shared utilities (including pagination)
- **Logging:** Logger configuration and helpers

---

## Customization

- **Add new features** in the appropriate folders.
- **Adjust authentication or logging** by editing the respective middleware and configuration files.
- **Update appsettings.json** for IIS virtual directory setups or other environment-specific settings.

---

## Creating Your Own Template

1. In Visual Studio, go to `File > Export Template`.
2. Choose "Project Template" and follow the wizard.
3. Distribute or reuse the template for new projects.

---

## Contributing

Contributions are welcome! Please open issues or submit pull requests.

---

## License

This project is licensed under the MIT License.

---

## Contact

For questions or suggestions, please open an issue or contact [AnandBugde](https://github.com/AnandBugde).
