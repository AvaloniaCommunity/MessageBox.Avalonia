using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxStandardParams : AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;
    }
}