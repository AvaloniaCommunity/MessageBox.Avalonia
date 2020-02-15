using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MessageBoxTest
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

        private async void MainWindow_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBox.Avalonia.DTO.MessageBoxStandardParams()
            {
                ShowInCenter = false,
                WindowStartupLocation=WindowStartupLocation.CenterOwner,
                ContentTitle = "Sup",
                ContentMessage = "Bro",
                Icon = MessageBox.Avalonia.Enums.Icon.Plus,
                Style = MessageBox.Avalonia.Enums.Style.None,
                ButtonDefinitions = MessageBox.Avalonia.Enums.ButtonEnum.YesNo,
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
