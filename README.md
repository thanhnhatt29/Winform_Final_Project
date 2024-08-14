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

The [`database`](https://github.com/thanhnhatt29/Winform_Final_Project/tree/main/database) folder contains SQL scripts for setting up and resetting the database.

## Images

The [`image`](https://github.com/thanhnhatt29/Winform_Final_Project/tree/main/image) folder contains images used in the application.

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
