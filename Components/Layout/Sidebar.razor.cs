using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Lists;

namespace Support.Components.Layout
{
    public partial class Sidebar : ComponentBase
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private readonly List<SidebarMenuItem> _data = new List<SidebarMenuItem>
        {
            new SidebarMenuItem { Id = 1, Title = "My Dashboard", FontIcon = "e-icons e-home", Path = "home" },
            new SidebarMenuItem { Id = 2, Title = "All Tickets", FontIcon = "e-icons e-notes", Path = "tickets" },
            new SidebarMenuItem { Id = 3, Title = "Chat", FontIcon = "e-icons e-comment-show", Path = "chat" },
            new SidebarMenuItem { Id = 4, Title = "Contacts", FontIcon = "e-icons e-user", Path = "contacts" },
            new SidebarMenuItem { Id = 5, Title = "Settings", FontIcon = "e-icons e-settings", Path = "settings" }
        };
        public List<SidebarMenuItem> ListData { get; set; } = new List<SidebarMenuItem>();

        protected override void OnInitialized()
        {
            int index = _data.FindIndex(data => NavigationManager.Uri.Contains(data.Path));
            var tempData = _data;
            foreach (var item in tempData)
            {
                item.SelectedItem = new Dictionary<string, object>();
            }
            if (index >= 0 && index < tempData.Count)
            {
                tempData[index].SelectedItem = new Dictionary<string, object> { { "class", "e-active" } };
            }
            ListData = tempData;
        }
        public void OnClickSidebarItem(ClickEventArgs<SidebarMenuItem> args)
        {
            NavigationManager.NavigateTo("support/" + args.ItemData.Path);
        }
    }

    public class SidebarMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FontIcon { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public Dictionary<string, object> SelectedItem { get; set; } = new Dictionary<string, object>();
    }
}