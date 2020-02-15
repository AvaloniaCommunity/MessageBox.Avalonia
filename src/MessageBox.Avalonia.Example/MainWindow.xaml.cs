using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.DTO;

using MessageBoxAvaloniaEnums = MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Example
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("btnClick").Click += MainWindow_Click;
        }

        private async void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxStandardWindow = MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ShowInCenter = false,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    ContentTitle = "Sup",
                    ContentMessage = "Bro",
                    Icon = MessageBoxAvaloniaEnums.Icon.Plus,
                    Style = MessageBoxAvaloniaEnums.Style.None,
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNo,
                    CanResize = false,
                });
            await messageBoxStandardWindow.ShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
