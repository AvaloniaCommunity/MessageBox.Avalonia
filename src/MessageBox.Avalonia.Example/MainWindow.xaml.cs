using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
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

        public async void MsBoxStandard_Click(object sender, RoutedEventArgs e)
        {
            /*var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.", MessageBoxAvaloniaEnums.ButtonEnum.Ok, MessageBoxAvaloniaEnums.Icon.Stopwatch)*/


            int maxWidth = 500;
            int maxHeight = 800;

            // If you want to auto strict the max sizes
            /*var screen = Screens?.ScreenFromVisual(this);
            if (!(screen is null))
            {
                maxWidth = (int) (screen.WorkingArea.Width / screen.PixelDensity - 100);
                maxHeight = (int) (screen.WorkingArea.Height / screen.PixelDensity - 50);
            }*/


            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.YesNoCancel,
                    ContentTitle = "title",
                    ContentHeader =
                        "Testing long header for debug purpose, this should never be that long, still it may allow it! " +
                        "Testing long header for debug purpose, this should never be that long, still it may allow it!" +
                        "Testing long header for debug purpose, this should never be that long, still it may allow it!",
                    ContentMessage =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n" +
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n",
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    CanResize = false,
                    MaxWidth = maxWidth,
                    MaxHeight = maxHeight,
                    ShowInCenter = true,
                    Icon = MessageBoxAvaloniaEnums.Icon.Error,
                    Topmost = true
                });

            await messageBoxStandardWindow.ShowDialog(this);
        }

        public async void MsBoxCustom_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxCustomWindow(
                new MessageBoxCustomParams
                {
                    ContentTitle = "title",
                    ContentMessage = "message",
                    FontFamily = "Microsoft YaHei,Simsun",
                    Icon = MessageBoxAvaloniaEnums.Icon.Error,
                    WindowIcon = null,
                    ButtonDefinitions = new[]
                        { new ButtonDefinition { Name = "确定", IsDefault = true }, },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                });
            await messageBoxCustomWindow.ShowDialog(this);
        }

        public async void MsBoxHyperlink_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxHyperlinkWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxHyperlinkWindow(new MessageBoxHyperlinkParams()
                {
                    CanResize = true,
                    Topmost = true,

                    HyperlinkContentProvider = new[]
                    {
                        new HyperlinkContent
                            { Alias = "dedede         ", Url = "https://avaloniaui.net/docs/styles/styles" },
                        new HyperlinkContent { Alias = "edvyydebbvydebvyed         " },
                        new HyperlinkContent { Url = "https://avaloniaui.net/docs/styles/styles" }
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok,
                });
            await messageBoxHyperlinkWindow.ShowDialog(this);
        }

        public async void MsBoxInput_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxInputWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxInputWindow(new MessageBoxInputParams
                {
                    Topmost = true,
                    ContentHeader = "Input your admin password below",
                    ContentMessage = "Password:",
                    IsPassword = true,
                    PasswordRevealMode = MessageBoxAvaloniaEnums.PasswordRevealModes.Hold,
                    ButtonDefinitions = new[]
                    {
                        new ButtonDefinition { Name = "Cancel", IsCancel = true },
                        new ButtonDefinition
                            { Name = "Confirm", IsDefault = true }
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Width = 500,

                    // The following code is required for multi line to ensure the best view experience:
                    //Multiline = true,
                    //Height = 500,
                    //SizeToContent = SizeToContent.Manual
                });
            await messageBoxInputWindow.ShowDialog(this);
        }

        private async void MsBoxCustomImage_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxCustomWindow(new MessageBoxCustomParamsWithImage
                {
                    Topmost = true,
                    ContentMessage = "Message",
                    Icon = new Bitmap("./icon-rider.png"),
                    ButtonDefinitions = new[]
                    {
                        new ButtonDefinition { Name = "My", IsCancel = true },
                        new ButtonDefinition
                            { Name = "Buttons", IsDefault = true }
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    WindowIcon = new WindowIcon("./icon-rider.png"),
                });
            await messageBoxCustomWindow.ShowDialog(this);
        }

        private async void MsBoxMarkdown_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxMarkdownWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow(new MessageBoxStandardParams()
                {
                    Topmost = true,
                    ContentMessage = "## 🚀 Features\r\n\r\n- CK3 1.5.1 compatibility #660 by @IhateTrains\r\n\r\n## 📦 Dependencies\r\n\r\n- Bump commonItems.NET from `7f45e76` to `9945bf0` #656 by @dependabot[bot]\r\n- Bump actions/checkout from 2 to 3 #657 by @dependabot[bot]",
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                });
            await messageBoxMarkdownWindow.ShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}