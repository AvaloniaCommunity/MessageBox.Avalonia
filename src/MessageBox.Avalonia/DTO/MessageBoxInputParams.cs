using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxInputParams : MessageBoxCustomParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public bool IsPassword { get; set; } = false;
        public string WatermarkText { get; set; } = null;

        public bool Multiline { get; set; }
    }
}