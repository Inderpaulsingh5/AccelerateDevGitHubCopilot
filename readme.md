# Library App

## Description
The Library App is a console application designed to manage library operations such as loaning books, returning books, and managing patron memberships. It is built using .NET 8.0 and follows a modular architecture with separate projects for core application logic, infrastructure, and the console interface.

## Project Structure
- `AccelerateDevGitHubCopilot.generated.sln` - Solution file for the project.
- `src/`
  - `Library.ApplicationCore/`
    - `Entities/` - Contains the core entities like `Book`.
    - `Enums/` - Contains enumerations used across the application.
    - `Interfaces/` - Contains interfaces like `ILoanRepository`.
    - `Services/` - Contains service classes for business logic.
    - `Library.ApplicationCore.csproj` - Project file for the core application logic.
  - `Library.Console/`
    - `appSettings.json` - Configuration file for the console application.
    - `CommonActions.cs` - Contains common actions for the console application.
    - `ConsoleApp.cs` - Main class for the console application.
    - `ConsoleState.cs` - Contains state management for the console application.
    - `Json/` - Contains JSON data files.
    - `Library.Console.csproj` - Project file for the console application.
    - `Program.cs` - Entry point for the console application.
  - `Library.Infrastructure/`
    - `Data/` - Contains data access implementations.
    - `Library.Infrastructure.csproj` - Project file for the infrastructure layer.
- `tests/`
  - `UnitTests/`
    - `ApplicationCore/` - Contains unit tests for the core application logic.

## Key Classes and Interfaces
- `src/Library.ApplicationCore/Entities/Book.cs` - Represents a book entity.
- `src/Library.ApplicationCore/Interfaces/ILoanRepository.cs` - Interface for loan repository.
- `src/Library.Console/ConsoleApp.cs` - Main class for the console application.
- `src/Library.Console/Program.cs` - Entry point for the console application.

## Usage
To run the console application, use the following command:

```sh
dotnet run --project src/Library.Console/Library.Console.csproj


## License
This project is licensed under the MIT License.
