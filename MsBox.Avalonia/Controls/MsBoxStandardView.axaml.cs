using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MsBox.Avalonia.Controls;

public partial class MsBoxStandardView : UserControl
{
    public MsBoxStandardView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}