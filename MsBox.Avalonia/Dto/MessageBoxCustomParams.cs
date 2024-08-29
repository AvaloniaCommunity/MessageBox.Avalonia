using Avalonia.Media.Imaging;

using MsBox.Avalonia.Enums;
using MsBox.Avalonia.Models;

namespace MsBox.Avalonia.Dto;

public class MessageBoxCustomParams : AbstractMessageBoxParams
{
    /// <summary>
    /// Image of window
    /// Only if Icon is None
    /// </summary>
    public Bitmap ImageIcon { get; set; }

    /// <summary>
    /// Icon of window
    /// Higher priority than ImageIcon
    /// </summary>
    public Icon Icon { get; set; } = Icon.None;

    /// <summary>
    /// Buttons
    /// </summary>
    public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }
}