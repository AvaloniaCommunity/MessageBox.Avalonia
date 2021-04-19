using MessageBox.Avalonia.Models;
using System.Collections.Generic;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParams : AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
    }
}