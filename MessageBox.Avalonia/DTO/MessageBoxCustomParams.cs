using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxCustomParams : AbstractMessageBoxParams
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
        public MsBoxCustomWindow Window { get; set; }
    }
}