using System;
using Avalonia;
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

            this.FindControl<Button>("btnClick").Click += MainWindow_Click;
        }

        private async void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxInputWindow(new MessageBoxInputParams {
                ContentMessage = "Message",
                ButtonDefinitions = new []
                {
                    new ButtonDefinition{Name = "My"},new ButtonDefinition{Name = "Buttons",Type = MessageBoxAvaloniaEnums.ButtonType.Colored},
                    
                },
               
            });
            var r =await messageBoxCustomWindow.Show();
            Console.WriteLine(r.Button);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
