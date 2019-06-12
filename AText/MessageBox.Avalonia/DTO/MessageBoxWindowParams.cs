using System;
using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;
using Button = MessageBox.Avalonia.Enums.Button;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxWindowParams
    {
        public bool CanResize { get; set; } = false;
        public string ContentTitle { get;  set; } = String.Empty;
        public string ContentHeader { get;  set; } = String.Empty;
        public string ContentMessage { get;  set; } =String.Empty;
        public int? MaxWidth { get; set; } = null;
        public MessageBoxWindow Window { get; set; }
        public Button Button { get; set; } = Button.Ok;
        public Icon Icon { get; set; } = Icon.Avalonia;
    }
}