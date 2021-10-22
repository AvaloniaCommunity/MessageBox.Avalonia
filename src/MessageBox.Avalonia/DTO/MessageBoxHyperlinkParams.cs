using System.Collections.Generic;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxHyperlinkParams : AbstractMessageBoxParams
    {
        /// <summary>
        /// Icon of window
        /// </summary>
        public Icon Icon { get; set; } = Icon.None;

        /// <summary>
        /// Buttons
        /// </summary>
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;

        public IEnumerable<HyperlinkContent> HyperlinkContentProvider { get; set; } = new List<HyperlinkContent>();
    }
}