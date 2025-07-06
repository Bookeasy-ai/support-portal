# Support Portal - Production Ready Blazor Application

A production-ready support portal application built with Blazor Server and Syncfusion's Essential UI Kit, designed for scalable customer support management with modern UI patterns and maintainable architecture.

## 🚀 Quick Start

### Prerequisites
- .NET 8.0 SDK
- Syncfusion license (required for production use)

### Running the Application
```bash
# Clone and navigate to the project
git clone <repository-url>
cd support-portal

# Restore dependencies
dotnet restore

# Run the application
dotnet run
```

Application will be available at:
- **HTTPS**: https://localhost:7260
- **HTTP**: http://localhost:5261

## 🏗️ Architecture Overview

### Technology Stack
- **.NET 8 Blazor Server** with Interactive Server Components
- **Syncfusion Blazor UI Kit** for enterprise-grade components
- **Tailwind CSS** for utility-first styling
- **Responsive Design** with mobile-first approach
- **Dark Mode Support** throughout the application

### Project Structure
```
├── Components/
│   ├── Layout/           # Layout components (MainLayout, NavMenu, Sidebar)
│   ├── Pages/            # Feature-based page organization
│   │   └── Support/      # Support portal features
│   │       ├── Home.razor
│   │       └── Tickets/  # Ticket management system
│   └── _Imports.razor
├── wwwroot/              # Static assets
├── Program.cs            # Application startup
└── *.csproj             # Project configuration
```

## 📋 Development Guidelines

### Component Development Standards

#### 1. **File Organization**
- Use **feature-based folder structure** for logical grouping
- Co-locate related files: `.razor`, `.razor.cs`, `.razor.css`
- Follow consistent naming: `ComponentName.razor`

#### 2. **Component Structure Template**
```csharp
@page "/your-route"
@namespace Support.Components.Pages

<section class="p-6 bg-gray-50 dark:bg-gray-950">
    <!-- Your component content -->
</section>

@code {
    // Component logic
}
```

#### 3. **CSS & Styling Standards**

**Tailwind CSS Usage:**
```css
/* Color System - Use semantic colors consistently */
Primary: indigo-500, blue-600        /* Actions, links */
Success: green-500, emerald-600      /* Success states */
Warning: amber-500, orange-600       /* Warning states */
Error: red-500, rose-600            /* Error states */
Neutral: gray-50 to gray-950        /* Backgrounds, text */

/* Layout Patterns - Maintain consistency */
Container: p-6, mx-auto, max-w-7xl
Cards: bg-white dark:bg-gray-800 rounded-lg shadow-sm
Spacing: gap-4, gap-6, gap-8 (consistent spacing scale)
```

**Component CSS Classes:**
```css
/* Syncfusion Integration */
e-card, e-card-header, e-card-content    /* Card components */
e-btn, e-primary, e-flat                 /* Button styles */
e-avatar, e-avatar-circle, e-avatar-small /* User avatars */
e-badge, e-badge-info, e-badge-success   /* Status indicators */
```

#### 4. **Responsive Design Requirements**
- **Mobile-first approach**: Design for mobile, enhance for desktop
- **Breakpoints**: `sm:640px`, `md:768px`, `lg:1024px`, `xl:1280px`
- **Component visibility**: Use `hidden sm:block` / `block sm:hidden`
- **Grid systems**: `grid-cols-1 md:grid-cols-2 lg:grid-cols-4`

#### 5. **Dark Mode Implementation**
All components MUST support dark mode:
```css
/* Required dark mode classes */
bg-gray-50 dark:bg-gray-950           /* Backgrounds */
text-gray-900 dark:text-white         /* Text */
border-gray-200 dark:border-gray-700  /* Borders */
```

### Data Management Standards

#### 1. **Data Models**
```csharp
// Use consistent property naming and types
public class TicketData 
{
    public int TicketId { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string Status { get; set; } = "Open";
    public DateTime CreatedDate { get; set; }
    // Include validation attributes for production
}
```

#### 2. **Service Layer**
```csharp
// Create services for data operations
public interface ITicketService
{
    Task<List<TicketData>> GetTicketsAsync();
    Task<TicketData> GetTicketByIdAsync(int id);
    Task<bool> CreateTicketAsync(TicketData ticket);
    Task<bool> UpdateTicketAsync(TicketData ticket);
}
```

#### 3. **Component Communication**
```csharp
// Use parameters for data passing
[Parameter] public string Title { get; set; } = "Default Title";
[Parameter] public EventCallback<TicketData> OnTicketSelected { get; set; }

// Inject services consistently
[Inject] private NavigationManager NavigationManager { get; set; } = default!;
[Inject] private ITicketService TicketService { get; set; } = default!;
```

### UI Pattern Standards

#### 1. **Navigation Patterns**
- **Sidebar navigation**: Icon-based with tooltips
- **Breadcrumb trails**: Show current page context
- **Search integration**: Global search with autocomplete

#### 2. **Data Display Patterns**
- **Dual view modes**: Provide both tile and grid views
- **Status indicators**: Use color-coded badges consistently
- **Loading states**: Implement loading spinners for async operations
- **Empty states**: Provide helpful messages when no data exists

#### 3. **Form Patterns**
- **Input validation**: Use built-in Syncfusion validation
- **Error handling**: Show clear error messages
- **Submit states**: Disable buttons during form submission
- **Auto-save**: Implement for better UX where appropriate

### Performance Standards

#### 1. **Component Optimization**
- Use `@rendermode="InteractiveServer"` appropriately
- Implement lazy loading for large datasets
- Use `@key` directives for list rendering
- Minimize re-renders with `ShouldRender()`

#### 2. **Asset Management**
- Optimize images (WebP format preferred)
- Use CDN for external resources
- Implement caching strategies
- Minimize bundle sizes

## 🔧 Production Configuration

### Required Environment Setup
1. **Syncfusion License**: Update `Program.cs` with valid license key
2. **Database Connection**: Replace static data with actual database
3. **Authentication**: Implement proper authentication/authorization
4. **Logging**: Configure structured logging with Serilog
5. **Error Handling**: Implement global error handling

### Security Considerations
- Implement proper authentication and authorization
- Sanitize all user inputs
- Use HTTPS in production
- Implement CSRF protection
- Regular security audits

### Deployment Checklist
- [ ] Configure production appsettings.json
- [ ] Set up SSL certificates
- [ ] Configure database connections
- [ ] Set up monitoring and logging
- [ ] Implement health checks
- [ ] Configure backup strategies

## 🧪 Testing Standards

### Unit Testing
- Test all business logic components
- Mock external dependencies
- Use bUnit for Blazor component testing
- Maintain minimum 80% code coverage

### Integration Testing
- Test API endpoints
- Database integration tests
- Authentication flow testing
- End-to-end user workflows

## 📖 Resources

### Syncfusion Documentation
- [Blazor Components](https://blazor.syncfusion.com/documentation/introduction)
- [Getting Started](https://blazor.syncfusion.com/documentation/getting-started/blazor-server-side-visual-studio)
- [Themes](https://blazor.syncfusion.com/documentation/appearance/themes)

### Development Resources
- [Blazor Documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/)
- [Tailwind CSS Documentation](https://tailwindcss.com/docs)
- [.NET 8 Documentation](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)

## 🤝 Contributing

1. Follow the established coding standards
2. Write tests for new features
3. Update documentation for significant changes
4. Ensure responsive design and dark mode support
5. Test across different browsers and devices

## 📝 License

This project is licensed under the MIT License. See the LICENSE file for details.

---

**Note**: This application is production-ready but requires proper configuration for deployment including database setup, authentication, and Syncfusion licensing.