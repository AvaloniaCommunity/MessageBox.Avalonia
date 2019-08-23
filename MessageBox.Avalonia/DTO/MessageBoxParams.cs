using System;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;


namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxParams
    {
        public bool ShowInCenter { get; set; } = true;
        public bool CanResize { get; set; } = false;
        public string ContentTitle { get;  set; } = string.Empty;
        public string ContentHeader { get;  set; } = null;
        public string ContentMessage { get;  set; } =string.Empty;
        public int? MaxWidth { get; set; } = null;
        public ButtonEnum Button { get; set; } = ButtonEnum.Ok;
        public Icon Icon { get; set; } = Icon.Avalonia;
        public Bitmap WindowIcon { get; set; } = null;
        public Style Style { get; set; } = Style.None;
    }
}