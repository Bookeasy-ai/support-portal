namespace Support.Components.Pages.Support.Tickets
{
    public class TicketData
    {
        public int TicketId { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Avatar { get; set; }
        public string Requester { get; set; }
        public string Mail { get; set; }
        public string Assignee { get; set; }
        public string Status { get; set; }
        public string PriorityLevel { get; set; }
        public string CreatedTime { get; set; }
        public DateTime DueDate { get; set; }
        public int CommentCount { get; set; }
}

    public class TicketDataService 
    {
        public static List<TicketData> TicketDataList = new List<TicketData>
        {
            new TicketData
            {
                TicketId = 98724,
                Subject = "Need a guide on setting 2FA or MFA for my account",
                Category = "Backend",
                Avatar = "avatar-2.jpg",
                Requester = "Dennison Duddell",
                Mail = "dennison@example.com",
                Assignee = "Gisella Sowten",
                Status = "Open",
                PriorityLevel = "High",
                CreatedTime = "Created 3 hrs ago",
                DueDate = new DateTime(2024, 7, 15),
                CommentCount = 0
            },
            new TicketData
            {
                TicketId = 98725,
                Subject = "I seek authorization to work out of office",
                Category = "Frontend",
                Avatar = "avatar-9.jpg",
                Requester = "Chicky Eilles",
                Mail = "chicky@example.com",
                Assignee = "Riffwire Admin",
                Status = "In-progress",
                PriorityLevel = "Medium",
                CreatedTime = "Created 5 hrs ago",
                DueDate = new DateTime(2024, 8, 30),
                CommentCount = 5
            },
            new TicketData
            {
                TicketId = 98726,
                Subject = "I kindly request authorization to work remotely",
                Category = "Database",
                Avatar = "avatar-9.jpg",
                Requester = "Chicky Eilles",
                Mail = "chicky@example.com",
                Assignee = "Riffwire Admin",
                Status = "Open",
                PriorityLevel = "High",
                CreatedTime = "Created 1 day ago",
                DueDate = new DateTime(2024, 7, 10),
                CommentCount = 0
            },
            new TicketData
            {
                TicketId = 98727,
                Subject = "Save progress not displaying for large files",
                Category = "Feature Request",
                Avatar = "avatar-11.jpg",
                Requester = "Andriette Fishbourn",
                Mail = "andriette@example.com",
                Assignee = "Gisella Sowten",
                Status = "Closed",
                PriorityLevel = "Low",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 7
            },
            new TicketData
            {
                TicketId = 98728,
                Subject = "UI freezes while saving large files",
                Category = "Version Control",
                Avatar = "avatar-11.jpg",
                Requester = "Andriette Fishbourn",
                Mail = "andriette@example.com",
                Assignee = "Bill Doma",
                Status = "In-progress",
                PriorityLevel = "Medium",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 5
            },
            new TicketData
            {
                TicketId = 98729,
                Subject = "Insufficient memory allocation leading to software crash",
                Category = "DevOps",
                Avatar = "avatar-11.jpg",
                Requester = "Andriette Fishbourn",
                Mail = "andriette@example.com",
                Assignee = "Gisella Sowten",
                Status = "Closed",
                PriorityLevel = "Low",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 2
            },
            new TicketData
            {
                TicketId = 98730,
                Subject = "Software crashing when saving large files",
                Category = "Maintenance",
                Avatar = "avatar-5.jpg",
                Requester = "Riffwire Admin",
                Mail = "riffwire@example.com",
                Assignee = "N/A",
                Status = "In-progress",
                PriorityLevel = "Low",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 4
            },
            new TicketData
            {
                TicketId = 98731,
                Subject = "Need more information on the services you provide",
                Category = "UX/UI Design",
                Avatar = "avatar-5.jpg",
                Requester = "Riffwire Admin",
                Mail = "riffwire@example.com",
                Assignee = "N/A",
                Status = "In-progress",
                PriorityLevel = "Medium",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 1
            },
            new TicketData
            {
                TicketId = 98732,
                Subject = "Prerequisites for the onboarding process",
                Category = "Localization",
                Avatar = "avatar-5.jpg",
                Requester = "Riffwire Admin",
                Mail = "riffwire@example.com",
                Assignee = "Gisella Sowten",
                Status = "Closed",
                PriorityLevel = "Low",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 0
            },
            new TicketData
            {
                TicketId = 98733,
                Subject = "Software installation for new hires",
                Category = "Security",
                Avatar = "avatar-8.jpg",
                Requester = "Bertina Slide",
                Mail = "bertina@example.com",
                Assignee = "Cybill Domanek",
                Status = "Open",
                PriorityLevel = "High",
                CreatedTime = "Created 2 days ago",
                DueDate = new DateTime(2024, 7, 5),
                CommentCount = 6
            }
        };
    }   
}