using MessageBox.Avalonia.Models;
using System.Collections.Generic;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParams : AbstractMessageBoxParams
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
        public string ContentMessage { get; set; }
    }
}