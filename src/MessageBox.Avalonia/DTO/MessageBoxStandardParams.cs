using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxStandardParams : AbstractMessageBoxParams
    {
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;
        public string ContentMessage { get; set; }
    }
}