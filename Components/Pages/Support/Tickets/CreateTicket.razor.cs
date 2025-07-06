
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.RichTextEditor;
namespace Support.Components.Pages.Support.Tickets
{
    public partial class CreateTicket : ComponentBase
    {
        public string PlaceholderText = "Enter Description. Type / to open a list, and @mention can be used to notify an agent.";
        public List<object> BrandData = new List<object>
        {
            new { Text = "AutoPlus", Value = "AutoPlus" },
            new { Text = "BoldDesk", Value = "BoldDesk" }
        };

        public List<ToolbarItemModel> Tools = new List<ToolbarItemModel>()
        {
            new ToolbarItemModel() { Command = ToolbarCommand.Bold },
            new ToolbarItemModel() { Command = ToolbarCommand.Italic },
            new ToolbarItemModel() { Command = ToolbarCommand.Underline },
            new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
            new ToolbarItemModel() { Command = ToolbarCommand.FontName },
            new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
            new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
            new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
            new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
            new ToolbarItemModel() { Command = ToolbarCommand.OrderedList },
            new ToolbarItemModel() { Command = ToolbarCommand.UnorderedList },
            new ToolbarItemModel() { Command = ToolbarCommand.Blockquote },
            new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
            new ToolbarItemModel() { Command = ToolbarCommand.Image },
            new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
        };
    }
}