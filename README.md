# Library Management System

This is a Library Management System project developed in C#. The project is structured into different layers to separate concerns and improve maintainability.

## Main Features

- **User Management**: Manage user accounts, including login and registration.
- **Book Management**: Add, update, delete, and search for books in the library.
- **Author Management**: Manage author information.
- **Borrow Management**: Handle borrowing and returning of books.
- **Reader Management**: Manage reader information and library cards.
- **Employee Management**: Manage Employee information.
- **Reporting**: Generate reports on library usage and book borrowing statistics.

## Project Structure

- **BLL (Business Logic Layer)**: Contains the business logic of the application.
- **DAL (Data Access Layer)**: Contains the data access logic and database models.
- **DTO (Data Transfer Objects)**: Contains the data transfer objects used to transfer data between layers.
- **Final**: Contains the user interface and main application logic.

## Database

The [`database`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspaces%2FWinform_Final_Project%2Fdatabase%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "/workspaces/Winform_Final_Project/database") folder contains SQL scripts for setting up and resetting the database.

## Images

The [`image`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspaces%2FWinform_Final_Project%2Fimage%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "/workspaces/Winform_Final_Project/image") folder contains images used in the application.

## Build and Run

### Prerequisites

- .NET Framework
- Visual Studio

### Setting Up

1. Clone the repository:
   ```sh
   git clone https://github.com/thanhnhatt29/Winform_Final_Project.git
   ```
2. Open the solution file Final.sln in Visual Studio.
3. Build the solution to restore the NuGet packages and compile the project.

### Running the Application

1. Set the Final project as the startup project.
2. Run the application from Visual Studio.