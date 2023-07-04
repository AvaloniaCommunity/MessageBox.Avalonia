namespace MsBox.Avalonia.Models;

public class ButtonDefinition
{
    /// <summary>
    /// Text in button
    /// </summary>
    public string Name { get; set; } = "OK";

    /// <summary>
    /// When true and if ENTER key is pressed, the button will be called
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// When true and if ESC key is pressed, the button will be called
    /// </summary>
    public bool IsCancel { get; set; }
}