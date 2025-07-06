
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
namespace Support.Components.Pages.Support.Tickets
{
    public partial class Contact : ComponentBase
    {

        [Inject]
        IJSRuntime JS { get; set; }
        public bool SidebarToggle { get; set; } = true;
        public bool CloseOnClick { get; set; }

        public List<ContactCategory> ContactCategories { get; set; } = new List<ContactCategory>
        {
            new ContactCategory { Id = 1, Field = "All Contacts" },
            new ContactCategory { Id = 2, Field = "Active Contacts" },
            new ContactCategory { Id = 3, Field = "Verified Contacts" },
            new ContactCategory { Id = 4, Field = "Unverified Yamia Contacts" }
        };

        public List<ContactDetail> ContactDetailsData { get; set; } = new List<ContactDetail>
        {
            new ContactDetail { Id = 1, Profile = new Profile { Name = "Jane Smith", Initial = "", ColorTheme = "", Avatar = "avatar-8.jpg" }, Email = "jane.smith@example.com", Group = "None", Status = "unverified" },
            new ContactDetail { Id = 2, Profile = new Profile { Name = "Mark Johnson", Initial = "", ColorTheme = "", Avatar = "avatar-1.jpg" }, Email = "mark.johnson@example.com", Group = "Yamia", Status = "verified" },
            new ContactDetail { Id = 3, Profile = new Profile { Name = "Emily White", Initial = "", ColorTheme = "", Avatar = "avatar-9.jpg" }, Email = "emily.white@example.com", Group = "None", Status = "verified" },
            new ContactDetail { Id = 4, Profile = new Profile { Name = "Tom Harris", Initial = "TH", ColorTheme = "Red", Avatar = "" }, Email = "tom.harris@example.com", Group = "Hyatt", Status = "verified" },
            new ContactDetail { Id = 5, Profile = new Profile { Name = "Lisa Green", Initial = "LG", ColorTheme = "Green", Avatar = "" }, Email = "lisa.green@example.us", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 6, Profile = new Profile { Name = "David Clark", Initial = "", ColorTheme = "", Avatar = "avatar-2.jpg" }, Email = "david.clark@example.com", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 7, Profile = new Profile { Name = "Rachel Lee", Initial = "RL", ColorTheme = "Blue", Avatar = "" }, Email = "rachel.lee@example.com", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 8, Profile = new Profile { Name = "Olivia Adams", Initial = "", ColorTheme = "", Avatar = "avatar-12.jpg" }, Email = "olivia.adams@example.com", Group = "Eare", Status = "verified" },
            new ContactDetail { Id = 9, Profile = new Profile { Name = "Lucas Robinson", Initial = "", ColorTheme = "", Avatar = "avatar-5.jpg" }, Email = "lucas.robinson@example.us", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 10, Profile = new Profile { Name = "Sophia Martinez", Initial = "", ColorTheme = "", Avatar = "avatar-10.jpg" }, Email = "sophia.martinez@example.com", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 11, Profile = new Profile { Name = "Terza Escale", Initial = "TE", ColorTheme = "Green", Avatar = "" }, Email = "tescale2@example.us", Group = "Eare", Status = "verified" },
            new ContactDetail { Id = 12, Profile = new Profile { Name = "Murdoch Duggon", Initial = "MD", ColorTheme = "Blue", Avatar = "" }, Email = "mduggonl@example.com", Group = "Doyle", Status = "verified" },
            new ContactDetail { Id = 13, Profile = new Profile { Name = "Marylinda Shrubb", Initial = "MS", ColorTheme = "Red", Avatar = "" }, Email = "mshrubbs@example.com", Group = "Eare", Status = "verified" }
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

        public string colorThemeClass(string colorTheme)
        {
            return colorTheme switch
            {
                "Red" => "!bg-red-100 !text-red-700 dark:!text-red-400",
                "Green" => "!bg-green-100 !text-green-700 dark:!text-green-500",
                "Blue" => "!bg-cyan-100 !text-cyan-700 dark:!text-cyan-600",
                "Orange" => "!bg-orange-100 !text-orange-700 dark:!text-orange-500",
                _ => ""
            };
        }

        public class ContactCategory
        {
            public int Id { get; set; }
            public string Field { get; set; }
        }

        public class ContactDetail
        {
            public int Id { get; set; }
            public Profile Profile { get; set; }
            public string Email { get; set; }
            public string Group { get; set; }
            public string Status { get; set; }
        }

        public class Profile
        {
            public string Name { get; set; }
            public string Avatar { get; set; }
            public string Initial { get; set; }
            public string ColorTheme { get; set; }
        }
    }
}