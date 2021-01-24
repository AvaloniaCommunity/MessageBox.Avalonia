using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBoxAvaloniaEnums = MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Example
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public async void MainWindow_Click(object sender, RoutedEventArgs e)
        {
           
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow1 = MessageBox.Avalonia.MessageBoxManager
                                .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow2 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow3 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow4 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow5 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow6 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow7 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow8 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  var messageBoxStandardWindow9 = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
                  messageBoxStandardWindow1.Show();
                  messageBoxStandardWindow2.Show();
                  messageBoxStandardWindow3.Show();
                  messageBoxStandardWindow4.Show();
                  messageBoxStandardWindow5.Show();
                  messageBoxStandardWindow6.Show();
                  messageBoxStandardWindow7.Show();
                  messageBoxStandardWindow8.Show();
                  messageBoxStandardWindow9.Show();

                  var r = await messageBoxStandardWindow.ShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
