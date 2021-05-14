using System;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public abstract class AbstractMessageBoxParams
    {
        public WindowIcon WindowIcon { get; set; } = null;
        public Style Style { get; set; } = Style.None;
        public bool CanResize { get; set; } = false;
        public bool ShowInCenter { get; set; } = true;
        public FontFamily FontFamily { get; set; } = FontFamily.Default;
        public string ContentTitle { get; set; } = string.Empty;
        public string ContentHeader { get; set; } = null;
        public string ContentMessage { get; set; } = string.Empty;
        public int MinWidth { get; set; } = 200;
        public int? MaxWidth { get; set; } = null;

        public int MinHeight { get; set; } = 100;
        public int? MaxHeight { get; set; } = null;

        public SizeToContent SizeToContent { get; set; } = SizeToContent.Height;

        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;
    }
}