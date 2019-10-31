using System.Collections.Generic;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxStandardParams
    {
        public bool CanResize { get; set; } = false;
        public bool ShowInCenter { get; set; } = true;
        public string ContentTitle { get;  set; } = string.Empty;
        public string ContentHeader { get;  set; } = null;
        public string ContentMessage { get;  set; } =string.Empty;
        public int? MaxWidth { get; set; } = null;
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;
        public Icon Icon { get; set; } = Icon.Avalonia;
        public Bitmap WindowIcon { get; set; } = null;
        public Style Style { get; set; } = Style.None;
        public MsBoxStandardWindow Window { get; set; }
    }
}