using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using MsBox.Avalonia.Base;

namespace MsBox.Avalonia.Windows;

public partial class MsBoxWindow : Window
{
    public MsBoxWindow()
    {
        InitializeComponent();
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