using Avalonia.Controls;
using Avalonia.Media;

namespace MessageBox.Avalonia.DTO;

public abstract class AbstractMessageBoxParams
{
    /// <summary>
    /// Window icon of app in title bar
    /// </summary>
    public WindowIcon WindowIcon { get; set; } = null;

    /// <summary>
    /// Ability of resizing window
    /// </summary>
    public bool CanResize { get; set; } = false;

    /// <summary>
    /// Show in center screen
    /// </summary>
    public bool ShowInCenter { get; set; } = true;

    /// <summary>
    /// Font in messagebox text
    /// </summary>
    public FontFamily FontFamily { get; set; } = FontFamily.Default;

    /// <summary>
    /// Title of window in title bar
    /// </summary>
    public string ContentTitle { get; set; } = string.Empty;

    /// <summary>
    /// Header of messagebox window
    /// </summary>
    public string ContentHeader { get; set; } = null;

    /// <summary>
    /// Main text of messagebox body
    /// </summary>
    public string ContentMessage { get; set; } = string.Empty;

    /// <summary>
    /// Whether to render the main text of messagebox body as Markdown text
    /// </summary>
    public bool Markdown { get; set; } = false;

    /// <summary>
    /// Minimal width of window (default 200)
    /// </summary>
    public double MinWidth { get; set; } = 200;

    /// <summary>
    /// Max width of window
    /// </summary>
    public double MaxWidth { get; set; } = double.PositiveInfinity;

    /// <summary>
    /// Actual width of window
    /// </summary>
    public double Width { get; set; } = double.NaN;

    /// <summary>
    /// Minimum height of window (default 100)
    /// </summary>
    public double MinHeight { get; set; } = 100;

    /// <summary>
    /// Max height of window
    /// </summary>
    public double MaxHeight { get; set; } = double.PositiveInfinity;

    /// <summary>
    /// Actual height of window
    /// </summary>
    public double Height { get; set; } = double.NaN;

    /// <summary>
    /// Setup height and weight based on content
    /// </summary>
    /// <remarks>
    /// Content - text size and icon (image) size
    /// </remarks>
    public SizeToContent SizeToContent { get; set; } = SizeToContent.WidthAndHeight;

    /// <summary>
    /// Position window
    /// </summary>
    public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;

    /// <summary>
    /// Determines system decorations (title bar, border, etc)
    /// </summary>
    public SystemDecorations SystemDecorations { get; set; } = SystemDecorations.Full;

    /// <summary>
    /// Window under all windows
    /// </summary>
    public bool Topmost { get; set; } = false;
}