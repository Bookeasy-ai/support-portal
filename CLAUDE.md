# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Architecture

This is a Blazor Server application built with .NET 8 that demonstrates a Support Portal using Syncfusion's Essential UI Kit for Blazor. The application showcases pre-designed UI blocks for rapid development of professional support ticket management systems.

### Key Components Structure
- **MainLayout.razor**: Primary layout with sidebar navigation and main content area
- **Support Portal**: Core functionality located in `Components/Pages/Support/`
  - Ticket management system with grid/tile views
  - Chat interface for ticket communication
  - Contact forms and settings
- **Data Layer**: `TicketData.cs` contains static sample data for tickets with properties like TicketId, Subject, Category, Status, PriorityLevel, etc.

### Technology Stack
- .NET 8 Blazor Server with Interactive Server Components
- Syncfusion Blazor UI components (Grid, Inputs, Lists, Navigations, ProgressBar, RichTextEditor)
- Tailwind CSS for styling
- Static file serving for assets (avatars, brand logos, scripts)

## Development Commands

### Running the Application
```bash
dotnet run
```
Application runs on:
- HTTPS: https://localhost:7260
- HTTP: http://localhost:5261

### Building the Application
```bash
dotnet build
```

### Restoring Dependencies
```bash
dotnet restore
```

## Configuration Notes

- Syncfusion license registration is required in `Program.cs:11` (currently empty string)
- Interactive Server rendering mode is enabled for all components
- Static files are served from `wwwroot/` including Tailwind CSS extensions
- Development environment uses detailed error pages and HSTS is disabled