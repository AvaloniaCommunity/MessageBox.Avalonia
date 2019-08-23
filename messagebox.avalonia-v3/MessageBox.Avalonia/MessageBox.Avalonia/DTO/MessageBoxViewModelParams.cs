using System.Collections.Generic;
using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxViewModelParams
    {
        public bool CanResize { get; set; } = false;
        public bool ShowInCenter { get; set; } = true;
        public string ContentTitle { get;  set; } = string.Empty;
        public string ContentHeader { get;  set; } = null;
        public string ContentMessage { get;  set; } =string.Empty;
        public int? MaxWidth { get; set; } = null;
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; } 
        public Icon Icon { get; set; } = Icon.Avalonia;

        public MBoxWindow Window { get; set; }
    }
}