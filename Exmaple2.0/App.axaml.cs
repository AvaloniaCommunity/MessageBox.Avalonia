using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;

using Exmaple2._0.ViewModels;
using Exmaple2._0.Views;

namespace Exmaple2._0;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = new Window
                {
                    Title = "Exmaple2._0",
                    Width = 480,
                    Height = 720,
                    Icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Exmaple2.0/Assets/avalonia-logo.ico"))),
                    Content = new MainView { DataContext = new MainWindowViewModel() }
                };
                break;
            case ISingleViewApplicationLifetime singleView:
                singleView.MainView = new MainView { DataContext = new MainWindowViewModel() };
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
