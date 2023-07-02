using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace MsBox.Avalonia.Windows;

public partial class MsBoxWindow : Window
{
    public MsBoxWindow()
    {
        InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        ShowInTaskbar = false;
        CanResize = false;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public async void CloseSafe()
    {
        await Dispatcher.UIThread.InvokeAsync(Close);
    }
}