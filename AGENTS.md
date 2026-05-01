# Repository Guidelines

## Project Structure & Module Organization
This repository is a small .NET solution centered on one console app:

- `ArrayandString.sln`: solution entry point for IDEs and CLI workflows.
- `ArrayandString/ArrayandString.csproj`: project file targeting `net10.0`.
- `ArrayandString/Program.cs`: current application entry point.

Keep production code under `ArrayandString/`. If the codebase grows, organize new classes by feature or problem area inside subfolders that match their namespaces. Add tests in a separate sibling project such as `ArrayandString.Tests/`.

## Build, Test, and Development Commands
Use the .NET CLI from the repository root:

- `dotnet restore ArrayandString.sln`: restore NuGet packages.
- `dotnet build ArrayandString.sln`: compile the solution in `Debug`.
- `dotnet run --project ArrayandString/ArrayandString.csproj`: run the console app locally.
- `dotnet build ArrayandString.sln -c Release`: verify release output before shipping.
- `dotnet test`: run tests once a test project has been added.

## Coding Style & Naming Conventions
Formatting is defined in `.editorconfig` and should be treated as the source of truth.

- Use spaces, with `4` spaces for `*.cs` and `2` spaces for project and config files.
- Prefer file-scoped namespaces and explicit types over `var`.
- Use PascalCase for types, methods, and public members.
- Use camelCase for parameters and locals.
- Use `_camelCase` for private fields and `s_camelCase` for private static fields.

Run IDE formatting before committing so changes stay aligned with the configured C# conventions.

## Testing Guidelines
There is no committed test project yet. New logic should ship with automated tests in a dedicated test project, preferably `ArrayandString.Tests`, using standard .NET test tooling such as xUnit or MSTest. Name test files after the unit under test, for example `StringUtilitiesTests.cs`, and keep test methods descriptive.

## Commit & Pull Request Guidelines
Git history currently starts with a short, imperative commit (`first commit`). Keep that style, but make messages more specific, for example `Add sliding window solution for longest substring`.

Pull requests should include:

- a short summary of the change,
- linked issue or task reference when applicable,
- test notes (`dotnet build`, `dotnet test`),
- console output or screenshots only when behavior changes are user-visible.
