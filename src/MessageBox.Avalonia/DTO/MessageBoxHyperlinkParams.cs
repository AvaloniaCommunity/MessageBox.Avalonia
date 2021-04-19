using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using System.Collections.Generic;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxHyperlinkParams : AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;
        public IEnumerable<HyperlinkContent> HyperlinkContentProvider { get; set; } = new List<HyperlinkContent>();
    }
}
