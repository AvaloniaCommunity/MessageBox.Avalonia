using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
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
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxHyperlinkWindow(new MessageBoxHyperlinkParams()
            {
                CanResize = true,
                 Style= MessageBoxAvaloniaEnums.Style.MacOs,
                HyperlinkContentProvider = new[]{
                    new HyperlinkContent { Alias = "dedede         ", Url = "https://avaloniaui.net/docs/styles/styles" },
                    new HyperlinkContent { Alias="edvyydebbvydebvyed         "},
                    new HyperlinkContent { Url= "https://avaloniaui.net/docs/styles/styles" }
                },
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok
            });
            messageBoxCustomWindow.Show();
            this.FindControl<Button>("btnClick").Click += MainWindow_Click;
        }

        private async void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxHyperlinkWindow(new MessageBoxHyperlinkParams() {
                CanResize = true,
                HyperlinkContentProvider = new []{ 
                    new HyperlinkContent { Alias = "dedede         ", Url = "https://avaloniaui.net/docs/styles/styles" },
                    new HyperlinkContent { Alias="edvyydebbvydebvyed         "},
                    new HyperlinkContent { Url= "https://avaloniaui.net/docs/styles/styles" }
                },
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                 ButtonDefinitions= MessageBoxAvaloniaEnums.ButtonEnum.Ok
            });
            //var messageBoxCustomWindow2 = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBoxStandardParams()
            //{
            //    CanResize = true,
            //    WindowStartupLocation = WindowStartupLocation.CenterScreen,
            //    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok
            //});
            //await messageBoxCustomWindow2.Show();
            var r = await messageBoxCustomWindow.Show();
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
