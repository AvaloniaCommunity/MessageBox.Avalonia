using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO;

public class MessageBoxStandardParams : AbstractMessageBoxParams
{
    /// <summary>
    /// Icon of window
    /// </summary>
    public Icon Icon { get; set; } = Icon.None;

    /// <summary>
    /// Default buttons
    /// </summary>
    public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;

    public ClickEnum EnterDefaultButton { get; set; } = ClickEnum.Default;
    public ClickEnum EscDefaultButton { get; set; } = ClickEnum.Default;
}