using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
namespace Support.Components.Pages.Support.Tickets
{
    public partial class Settings : ComponentBase
    {

        [Inject]
        IJSRuntime JS { get; set; }
        public bool SidebarToggle { get; set; } = true;
        public bool CloseOnClick { get; set; }

        public List<SettingCategory> SettingCategories { get; set; } = new List<SettingCategory>
        {
            new SettingCategory { Text = "Field Name" },
            new SettingCategory { Text = "Ticket Templates" },
            new SettingCategory { Text = "Ticket Views" },
            new SettingCategory { Text = "Ticket Macros" },
            new SettingCategory { Text = "Canned Responses" },
            new SettingCategory { Text = "Email Notifications" },
            new SettingCategory { Text = "Tags" }
        };

        public List<Ticket> TicketData { get; set; } = new List<Ticket>
        {
            new Ticket { Id = 1, View = "All Tickets", Owner = "System Default", Scope = "public", Status = true },
            new Ticket { Id = 2, View = "All Pending Tickets", Owner = "System Default", Scope = "public", Status = true },
            new Ticket { Id = 3, View = "All Response Overdue Tickets", Owner = "System Default", Scope = "public", Status = true },
            new Ticket { Id = 4, View = "All Tickets with Resolution Due Today", Owner = "System Default", Scope = "public", Status = true },
            new Ticket { Id = 5, View = "All Unassigned Tickets", Owner = "System Default", Scope = "public", Status = true },
            new Ticket { Id = 6, View = "All Unsolved Tickets", Owner = "System Default", Scope = "public", Status = true }
        };

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var width = await JS.InvokeAsync<double>("eval", "window.innerWidth");
                UpdateSidebarState(width);
            }
        }

        private void UpdateSidebarState(double width)
        {
            CloseOnClick = width < 1023;
            StateHasChanged();
        }

        public void ToggleSidebar()
        {
            SidebarToggle = !SidebarToggle;
        }

        public class SettingCategory
        {
            public string Text { get; set; }
        }

        public class Ticket
        {
            public int Id { get; set; }
            public string View { get; set; }
            public string Owner { get; set; }
            public string Scope { get; set; }
            public bool Status { get; set; }
        }
    }
}