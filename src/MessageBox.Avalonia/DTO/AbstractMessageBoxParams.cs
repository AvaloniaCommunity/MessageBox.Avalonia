using System;
using Avalonia.Controls;
using Avalonia.Media;
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
        public double MinWidth { get; set; } = 200;
        public double MaxWidth { get; set; } = double.PositiveInfinity;
        public double Width { get; set; } = double.NaN;

        public double MinHeight { get; set; } = 100;
        public double MaxHeight { get; set; } = double.PositiveInfinity;
        public double Height { get; set; } = double.NaN;

        public SizeToContent SizeToContent { get; set; } = SizeToContent.Height;

        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;
    }
}