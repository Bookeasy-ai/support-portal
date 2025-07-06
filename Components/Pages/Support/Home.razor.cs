using Microsoft.AspNetCore.Components;

namespace Support.Components.Pages
{
    public partial class Home : ComponentBase
    {
        public string TicketFilterChecked = "Tickets";
        public List<Ticket> TicketData = new()
        {
            new Ticket { Id = 1, TicketId = 204, Subject = "Need a guide on setting up 2FA or MFA for my account", CreatedOn = new DateTime(2024, 11, 19, 12, 55, 0), Status = "Follow-up Scheduled", Brand = "AutoPlus" },
            new Ticket { Id = 2, TicketId = 182, Subject = "Save program not displaying large files properly", CreatedOn = new DateTime(2024, 10, 24, 12, 46, 0), Status = "Open", Brand = "AutoPlus" },
            new Ticket { Id = 3, TicketId = 181, Subject = "UI freezes while saving large files", CreatedOn = new DateTime(2024, 9, 10, 13, 34, 0), Status = "Open", Brand = "AutoPlus" },
            new Ticket { Id = 4, TicketId = 180, Subject = "Insufficient memory allocation leading to a software crash", CreatedOn = new DateTime(2024, 8, 21, 11, 57, 0), Status = "Follow-up Scheduled", Brand = "AutoPlus" },
            new Ticket { Id = 5, TicketId = 146, Subject = "Prerequisites for the onboarding process", CreatedOn = new DateTime(2024, 8, 6, 18, 25, 0), Status = "Follow-up Scheduled", Brand = "AutoPlus" },
            new Ticket { Id = 6, TicketId = 139, Subject = "Upgrading of office equipment", CreatedOn = new DateTime(2024, 7, 9, 12, 19, 0), Status = "Waiting for Customer", Brand = "AutoPlus" },
            new Ticket { Id = 7, TicketId = 118, Subject = "Feature request to support automatic upload of received files", CreatedOn = new DateTime(2024, 7, 3, 10, 27, 0), Status = "Follow-up Scheduled", Brand = "AutoPlus" }
        };

        public IEnumerable<dynamic> SatisfactionData => new[]
        {
            new { Label = "Positive", Percentage = "80%", Ratings = "160 Ratings", Color = "text-green-700 dark:text-green-500" },
            new { Label = "Neutral", Percentage = "10%", Ratings = "20 Ratings", Color = "text-orange-700 dark:text-orange-500" },
            new { Label = "Negative", Percentage = "10%", Ratings = "20 Ratings", Color = "text-orange-700 dark:text-orange-500" }
        };

        public int GetStatusCount(string status)
        {
            return status switch
            {
                "Pending" => 6,
                "On Hold" => 1,
                "Resolution Due" => 4,
                "Response Due" => 0,
                _ => 0
            };
        }

    }
     public class Ticket
    {
        public int Id { get; set;}
        public int TicketId { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public string Brand { get; set; }
    }

}