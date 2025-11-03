using MsBox.Avalonia.Enums;

namespace MsBox.Avalonia.Dto;

public class MessageBoxStandardParams : AbstractMessageBoxParams
{
    /// <summary>
    /// Icon of window
    /// </summary>
    public Icon Icon { get; set; } = Icon.None;

    /// <summary>
    /// View model for embedded context.
    /// </summary>
    public object? Context { get; set; } = null;

    /// <summary>
    /// Default buttons
    /// </summary>
    public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;

    public ClickEnum EnterDefaultButton { get; set; } = ClickEnum.Default;
    public ClickEnum EscDefaultButton { get; set; } = ClickEnum.Default;
}