using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public abstract class AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public Bitmap WindowIcon { get; set; } = null;
        public Style Style { get; set; } = Style.None;
        public bool CanResize { get; set; } = false;
        public bool ShowInCenter { get; set; } = true;
        public string ContentTitle { get; set; } = string.Empty;
        public string ContentHeader { get; set; } = null;
        public string ContentMessage { get; set; } = string.Empty;
        public int? MaxWidth { get; set; } = null;
        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;
    }
}