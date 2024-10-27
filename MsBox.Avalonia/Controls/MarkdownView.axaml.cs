using Avalonia;
using Avalonia.Controls.Primitives;

namespace MsBox.Avalonia.Controls;

public class MarkdownView : TemplatedControl
{
    public static readonly StyledProperty<string?> MarkdownProperty =
        AvaloniaProperty.Register<MarkdownView, string?>(nameof(Markdown));
    
    public string? Markdown
    {
        get => GetValue(MarkdownProperty);
        set => SetValue(MarkdownProperty, value);
    }
}
