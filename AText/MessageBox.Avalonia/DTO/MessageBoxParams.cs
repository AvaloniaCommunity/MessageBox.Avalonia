using System;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;
using Button = MessageBox.Avalonia.Enums.Button;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxParams
    {
        public bool CanResize { get; set; } = false;
        public string ContentTitle { get;  set; } = string.Empty;
        public string ContentHeader { get;  set; } = null;
        public string ContentMessage { get;  set; } =string.Empty;
        public int? MaxWidth { get; set; } = null;
        public Button Button { get; set; } = Button.Ok;
        public Icon Icon { get; set; } = Icon.Avalonia;
        public Window ParentWindow { get; set; } = null;
        public Bitmap WindowIcon { get; set; } = null;
        public Style Style { get; set; } = Style.None;
    }
}