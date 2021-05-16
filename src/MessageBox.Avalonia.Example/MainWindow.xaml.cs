using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
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

        public async void MsBoxStandard_Click(object sender, RoutedEventArgs e)
        {
           
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.", MessageBoxAvaloniaEnums.ButtonEnum.Ok, MessageBoxAvaloniaEnums.Icon.Stopwatch);
            var r = await messageBoxStandardWindow.ShowDialog(this);
        }

        public async void MsBoxCustom_Click(object sender, RoutedEventArgs e)
        {

            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxCustomWindow(new MessageBoxCustomParams
                {
                    Style = Style.UbuntuLinux,
                    ContentMessage = "支持FontFamily",
                    FontFamily = "Microsoft YaHei,Simsun",
                    Icon = MessageBoxAvaloniaEnums.Icon.Success,
                    ButtonDefinitions = new[] {
                        new ButtonDefinition {Name = "My"},
                        new ButtonDefinition {Name = "Buttons", Type = ButtonType.Colored}
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                });
            var r = await messageBoxCustomWindow.ShowDialog(this);
        }

        public async void MsBoxHyperlink_Click(object sender, RoutedEventArgs e)
        {

            var messageBoxHyperlinkWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxHyperlinkWindow(new MessageBoxHyperlinkParams()
                {
                    CanResize = true,
                    Style = MessageBoxAvaloniaEnums.Style.MacOs,
                    HyperlinkContentProvider = new[]{
                        new HyperlinkContent { Alias = "dedede         ", Url = "https://avaloniaui.net/docs/styles/styles" },
                        new HyperlinkContent { Alias="edvyydebbvydebvyed         "},
                        new HyperlinkContent { Url= "https://avaloniaui.net/docs/styles/styles" }
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                    });
            var r = await messageBoxHyperlinkWindow.ShowDialog(this);
        }

        public async void MsBoxInput_Click(object sender, RoutedEventArgs e)
        {

            var messageBoxInputWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxInputWindow(new MessageBoxInputParams
                {
                    Style = Style.UbuntuLinux,
                    ContentMessage = "This is input window! Type something in this field!",
                    InputHeader = "Field",
                    ButtonDefinitions = new[] {
                        new ButtonDefinition {Name = "Cancel"},
                        new ButtonDefinition {Name = "Confirm", Type = ButtonType.Colored}
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                });
            var r = await messageBoxInputWindow.ShowDialog(this);
        }
        private async void MsBoxCustomImage_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxCustomWindow(new MessageBoxCustomParamsWithImage
                {
                    Style = Style.UbuntuLinux,
                    ContentMessage = "Message",
                    Icon = new Bitmap("./icon-rider.png"),
                    ButtonDefinitions = new[] {
                        new ButtonDefinition {Name = "My"},
                        new ButtonDefinition {Name = "Buttons", Type = ButtonType.Colored}
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                });
            var r = await messageBoxCustomWindow.ShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


        private async void MsBoxInputPass_Click(object? sender, RoutedEventArgs e)
        {
            var messageBoxInputWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxInputWindow(new MessageBoxInputParams
                {
                    Style = Style.UbuntuLinux,
                    ContentMessage = "Please type your password",
                    InputHeader = "Password",
                    IsPassword = true,
                    ButtonDefinitions = new[] {
                        new ButtonDefinition {Name = "Cancel"},
                        new ButtonDefinition {Name = "Confirm", Type = ButtonType.Colored}
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                });
            await messageBoxInputWindow.ShowDialog(this);
        }
    }
}
