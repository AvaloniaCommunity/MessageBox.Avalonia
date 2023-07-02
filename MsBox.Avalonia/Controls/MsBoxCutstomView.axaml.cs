using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MsBox.Avalonia.Controls;

public partial class MsBoxCutstomView : UserControl
{
    public MsBoxCutstomView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}