# ElementFactory

ElementFactory is an ASP.NET Core educational web application for learning chemistry through chemical elements, flashcards, questions, answers, and tests.

## Features

- Chemical element catalogue
- Question and answer management
- Test creation and mapping between questions and tests
- Flashcard-oriented learning data model
- ASP.NET Core Identity authentication and role support
- Entity Framework Core with SQL Server
- Repository and service layers
- Unit tests for repositories and services

## Tech Stack

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- Razor Views
- xUnit-style test project

## Solution Structure

```text
ElementFactory/          # Web application
ElementFactory.Core/     # Services, repositories, contracts, extensions
ElementFactory.Data/     # EF Core context, models, migrations, configuration
ElementFactory.Tests/    # Repository and service tests
ElementFactory.sln
```

## Getting Started

### Prerequisites

- .NET SDK
- SQL Server or SQL Server LocalDB

### Run Locally

```bash
git clone https://github.com/alex-stefanov/ElementFactory.git
cd ElementFactory
dotnet restore ElementFactory.sln
dotnet build ElementFactory.sln
dotnet run --project ElementFactory
```

Configure the `DefaultConnection` connection string in `ElementFactory/appsettings.json` or through user secrets before running migrations.

## Testing

```bash
dotnet test ElementFactory.sln
```

## License

This project is licensed under the MIT License.
