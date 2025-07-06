using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;

namespace Support.Components.Pages.Support.Tickets
{
    public partial class Tickets : ComponentBase
    {

        [Inject]
        IJSRuntime JS { get; set; }
        public bool SidebarToggle { get; set; } = true;
        public bool CloseOnClick { get; set; }
        public string SelectedItem { get; set; } = "Tile View";

        public List<TicketItem> TicketListData { get; set; } = new List<TicketItem>
        {
            new TicketItem { Id = 1, Content = "All Pending Tickets" },
            new TicketItem { Id = 2, Content = "All Response Overdue Tickets" },
            new TicketItem { Id = 3, Content = "All Tickets" },
            new TicketItem { Id = 4, Content = "All Tickets Resolution Due" },
            new TicketItem { Id = 5, Content = "All Unassigned Tickets" },
            new TicketItem { Id = 6, Content = "All Unsolved Tickets" },
            new TicketItem { Id = 7, Content = "All Pending Tickets" },
            new TicketItem { Id = 8, Content = "My Resolution Overdue Tickets" },
            new TicketItem { Id = 9, Content = "My Response Overdue Tickets" },
            new TicketItem { Id = 10, Content = "My Today's Resolution Due" },
            new TicketItem { Id = 11, Content = "My Unsolved Tickets" },
            new TicketItem { Id = 12, Content = "Requested By Myself" },
            new TicketItem { Id = 13, Content = "SLA Breached Tickets" },
            new TicketItem { Id = 14, Content = "Tickets I am CCed on" },
            new TicketItem { Id = 15, Content = "Tickets I am Mentioned In" }
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

        public void ToggleFavorite(TicketItem item)
        {
            item.IsFavorite = !item.IsFavorite;
        }
        
        public void ToggleViewMode(MenuEventArgs args)
        {
            SelectedItem = args.Item.Text;
        }
    }
    public class TicketItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsFavorite { get; set; } = false;
    }
}