using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;
using System.Globalization;
using Microsoft.AspNetCore.Components.Routing;

namespace Support.Components.Layout
{
    public partial class NavMenu : ComponentBase, IDisposable
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Title { get; set; } = "Support Dashboard";
        SfMenu<SupportMenuItem>? MenuObj; 

        List<SupportMenuItem> SupportMenuItems = new List<SupportMenuItem>
        {
            new SupportMenuItem { Text = "Home", IconCss = "e-icons e-home", Url = "/support/home" },
            new SupportMenuItem { Text = "Ticket", IconCss = "e-icons e-notes", Url = "/support/tickets" },
            new SupportMenuItem { Text = "Chat", IconCss = "e-icons e-comment-show", Url = "/support/chat" },
            new SupportMenuItem { Text = "Contacts", IconCss = "e-icons e-user", Url = "/support/contacts" },
            new SupportMenuItem { Text = "Settings", IconCss = "e-icons e-settings", Url = "/support/settings" }
        };

        public readonly List<SearchDataItem> SearchData = new List<SearchDataItem>
        {
            new SearchDataItem { Id = "#23568", Ticket = "Unable to log in to the application", CreatedDate = "October 5, 2024", FontIcon = "e-icons e-circle-info", ColorTheme = "Green" },
            new SearchDataItem { Id = "#23562", Ticket = "Software update error", CreatedDate = "October 1, 2024", FontIcon = "e-icons e-reset", ColorTheme = "Orange" },
            new SearchDataItem { Id = "#23556", Ticket = "Feature request: Dark mode", CreatedDate = "September 28, 2024", FontIcon = "e-icons e-objects", ColorTheme = "Blue" }
        };

        protected override void OnInitialized()
        {
            NavigationManager.LocationChanged += OnLocationChanged;
        }
        private void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            string url = new Uri(NavigationManager.Uri).AbsolutePath;
            var pathParts = url.Split('/', StringSplitOptions.RemoveEmptyEntries);
            Title = pathParts.Length > 0 ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pathParts[^1]) : "Home";
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }

        public void NavigateToCreateTicket(MenuEventArgs args)
        {
            if (args.Item.Text == "Ticket")
            {
                NavigationManager.NavigateTo($"/support/create-{args.Item.Text.ToLower()}");
            }
        }
        public void NavigateToModule(MenuEventArgs<SupportMenuItem> args)
        {
            
            MenuObj?.CloseAsync();
            if (args.Item.Text == "Ticket")
            {
                NavigationManager.NavigateTo(args.Item.Url);
            }
        }
    }

    public class MenuItem
    {
        public string Text { get; set; }
        public string IconCss { get; set; }
    }

    public class SupportMenuItem
    {
        public string Text { get; set; }
        public string IconCss { get; set; }
        public string Url { get; set; }
    }

    public class SearchDataItem
    {
        public string Id { get; set; }
        public string Ticket { get; set; }
        public string CreatedDate { get; set; }
        public string FontIcon { get; set; }
        public string ColorTheme { get; set; }
    }
}