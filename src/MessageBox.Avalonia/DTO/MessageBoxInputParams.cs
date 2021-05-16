using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxInputParams : MessageBoxCustomParams
    {
        public string InputHeader { get; set; } = null;
        public Icon Icon { get; set; } = Icon.None;
        public bool IsPassword { get; set; } = false;
        public string WatermarkText { get; set; } = null;
        public bool AllowMultiline { get; set; } = false;
    }
}