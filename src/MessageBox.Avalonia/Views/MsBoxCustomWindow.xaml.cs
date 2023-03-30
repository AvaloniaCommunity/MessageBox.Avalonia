using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;

namespace MessageBox.Avalonia.Views;

public class MsBoxCustomWindow : BaseWindow, IWindowGetResult<string>
{
    public MsBoxCustomWindow() : base()
    {
        InitializeComponent();
    }

    public string ButtonResult { get; set; } = null;

    public string GetResult() => ButtonResult;

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}