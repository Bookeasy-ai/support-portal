using Microsoft.AspNetCore.Components;

namespace Support.Components.Pages.Support.Tickets
{
    public partial class Chat : ComponentBase
    {
        private string ChatWidth { get; set; } = "max-width:608px";

        public class ChatDataModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
            public string Avatar { get; set; }
            public string Text { get; set; }
            public string Chat { get; set; }
            public bool Open { get; set; }
            public bool Send { get; set; }
            public string Content { get; set; }
        }

        public List<ChatDataModel> ContactData = new List<ChatDataModel>
        {
            new ChatDataModel { Id = 1, Name = "Marvin McKinney", Content = "Oh yeah, I did! I’ve heard it.", Avatar = "avatar-1.jpg", Send = true },
            new ChatDataModel { Id = 2, Name = "Leslie Alexander", Content = "That’s likely the issue.", Avatar = "avatar-9.jpg", Send = false },
            new ChatDataModel { Id = 3, Name = "Savannah Nguyen", Content = "Well, if there’s one thing I know...", Avatar = "avatar-10.jpg", Send = true },
            new ChatDataModel { Id = 4, Name = "Robert Fox", Content = "Easy. A lifetime supply of happiness!", Avatar = "avatar-2.jpg", Send = false },
            new ChatDataModel { Id = 5, Name = "Bessie Cooper", Content = "Oh, and maybe a pet too!", Avatar = "avatar-11.jpg", Send = true },
            new ChatDataModel { Id = 6, Name = "Guy Hawkins", Content = "Definitely! And don’t forget to smile.", Avatar = "avatar-3.jpg", Send = true },
            new ChatDataModel { Id = 7, Name = "Wade Warren", Content = "Easy, just roll up some ideas.", Avatar = "avatar-4.jpg", Send = true },
            new ChatDataModel { Id = 8, Name = "Darrell Steward", Content = "Genius! I’m going to start a new project.", Avatar = "avatar-6.jpg", Send = true },
            new ChatDataModel { Id = 9, Name = "Esther Howard", Content = "annette.black@fusionui.com", Avatar = "avatar-14.jpg", Send = true }
        };

        public List<ChatDataModel> ChatData = new List<ChatDataModel>
        {
            new ChatDataModel { Id = 1, Name = "John", Time = "8:57 AM", Avatar = "", Text = "Hi, I’m having trouble accessing the company VPN.", Chat = "sender", Open = false },
            new ChatDataModel { Id = 2, Name = "Leslie Alexander", Time = "9:00 AM", Avatar = "avatar-9.jpg", Text = "Hello! I can help with that. Are you seeing any error messages?", Chat = "receiver" },
            new ChatDataModel { Id = 3, Name = "John", Time = "9:05 AM", Avatar = "", Text = "Yes, it says \"VPN connection failed. Authentication error.\"", Chat = "sender", Open = false },
            new ChatDataModel { Id = 4, Name = "Leslie Alexander", Time = "10:00 AM", Avatar = "avatar-9.jpg", Text = "Thanks for the details. Can you confirm if you’ve recently changed your network password?", Chat = "receiver" },
            new ChatDataModel { Id = 5, Name = "John", Time = "10:32 AM", Avatar = "", Text = "Yes, I changed it yesterday.", Chat = "sender", Open = true },
            new ChatDataModel { Id = 6, Name = "Leslie Alexander", Time = "10:35 AM", Avatar = "avatar-9.jpg", Text = "That’s likely the issue. The VPN might still be using the old password. Try updating your VPN credentials with the new password.", Chat = "receiver" }
        };
    }
}