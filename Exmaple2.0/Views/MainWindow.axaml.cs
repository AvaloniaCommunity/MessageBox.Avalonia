using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

using Exmaple2._0.ViewModels;

using MsBox.Avalonia;
using MsBox.Avalonia.Controls;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.Models;
using MsBox.Avalonia.ViewModels;

using static System.Net.Mime.MediaTypeNames;

namespace Exmaple2._0.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();

#endif
    }

    private async void Standard_Show_OnClick(object sender, RoutedEventArgs e)
    {
        var box = MessageBoxManager
            .GetMessageBoxStandard("Caption", "Are you sure you would like to delete appender_replace_page_1?",
                ButtonEnum.YesNo);

        var result = await box.ShowAsPopupAsync(this);
    }

    private async void Standard_Context_Show_OnClick(object sender, RoutedEventArgs e)
    {
        var box = MessageBoxManager
            .GetMessageBoxStandard(
                "Caption",
                "Are you sure you would like to delete appender_replace_page_1?",
                ButtonEnum.YesNo,
                context: new EmbeddedViewModel());

        var result = await box.ShowAsPopupAsync(this);
    }

    private async void Standard_Dialog_OnClick(object sender, RoutedEventArgs e)
    {
        int maxWidth = 500;
        int maxHeight = 800;
        var box = MessageBoxManager.GetMessageBoxStandard(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = ButtonEnum.Ok,
                ContentTitle = "title",
                //ContentHeader = header,
                ContentMessage = "Informative note:\n\n" +
                                 string.Concat(Enumerable.Repeat(
                                     "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n",
                                     50)),
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = maxWidth,
                MaxHeight = maxHeight,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false
            });

        var result = await box.ShowWindowDialogAsync(this);
        var i = 0;
    }


    private async void Standard_Popup_OnClick(object sender, RoutedEventArgs e)
    {
        int maxWidth = 500;
        int maxHeight = 800;
        var box = MessageBoxManager.GetMessageBoxStandard(
            new MessageBoxStandardParams
            {
                ButtonDefinitions = ButtonEnum.Ok,
                ContentTitle = "title",
                //ContentHeader = header,
                ContentMessage = "Informative note:\n\n" +
                                 string.Concat(Enumerable.Repeat(
                                     "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n",
                                     50)),
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = maxWidth,
                MaxHeight = maxHeight,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false
            });

        var result = await box.ShowAsPopupAsync(this);
    }

    private void Custom_Dialog_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = MessageBoxManager.GetMessageBoxCustom(
            new MessageBoxCustomParams
            {
                ButtonDefinitions = new List<ButtonDefinition>
                {
                    new ButtonDefinition { Name = "Yes", },
                    new ButtonDefinition { Name = "No", },
                    new ButtonDefinition { Name = "Cancel", }
                },
                ContentTitle = "title",
                ContentMessage = "Informative note:" +
                                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n",
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = 500,
                MaxHeight = 800,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false,
                HyperLinkParams = new HyperLinkParams
                {
                    Text = "https://docs.avaloniaui.net/",
                    Action = new Action(() =>
                    {
                        var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var url = "https://docs.avaloniaui.net/";
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            //https://stackoverflow.com/a/2796367/241446
                            using var proc = new Process { StartInfo = { UseShellExecute = true, FileName = url } };
                            proc.Start();

                            return;
                        }

                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        {
                            Process.Start("x-www-browser", url);
                            return;
                        }

                        if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                            throw new Exception("invalid url: " + url);
                        Process.Start("open", url);
                        return;
                    })
                }
            });

        dialog.ShowWindowDialogAsync(this);
    }

    private void Custom_Show_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Custom_PopUp_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private async void Custom_MarkDown_OnClick(object sender, RoutedEventArgs e)
    {
        const int maxWidth = 800;
        const int maxHeight = 700;
        var box = MessageBoxManager.GetMessageBoxCustom(
            new MessageBoxCustomParams
            {
                ContentTitle = "title",
                ContentMessage = """
# h1 Heading
## h2 Heading
### h3 Heading
#### h4 Heading
##### h5 Heading
###### h6 Heading

## Emphasis
**This is bold text**

__This is underlined text__

*This is italic text*

~~Strikethrough~~

## Blockquotes
> Blockquotes can also be nested...
>> ...by using additional greater-than signs right next to each other...
> > > ...or with spaces between arrows.

## Lists
Unordered
+ Create a list by starting a line with `+`, `-`, or `*`
+ Sub-lists are made by indenting 2 spaces:
  - Marker character change forces new list start:
    * Ac tristique libero volutpat at
    - Nulla volutpat aliquam velit

Ordered
1. Lorem ipsum dolor sit amet
2. Consectetur adipiscing elit

## Code

Inline `code`

Indented code

    // Some comments
    line 1 of code


Block code "fences"

```
Sample text here...
```

Syntax highlighting
```js
var foo = function (bar) {
  return bar++;
};

console.log(foo(5));
```

## Links
[link text](https://example.com)

## Images
![Message](https://github.com/AvaloniaCommunity/MessageBox.Avalonia/raw/master/MsBox.Avalonia/icon.jpg)

## Emojies
:wink: :cry: :laughing: :yum:
""",
                Icon = MsBox.Avalonia.Enums.Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = maxWidth,
                MaxHeight = maxHeight,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false,
                Markdown = true,
                ButtonDefinitions = [
					new() {Name = "OK", IsDefault = true},
				],
            });

        var result = await box.ShowAsync();
    }

    private async void Custom_CloseClickAway_OnClick(object sender, RoutedEventArgs e)
    {
        var result = await MessageBoxManager.GetMessageBoxCustom(
            new MessageBoxCustomParams
            {
                ButtonDefinitions = new List<ButtonDefinition>{
                    new ButtonDefinition { Name = "Yes", },
                    new ButtonDefinition { Name = "No", },
                    new ButtonDefinition { Name = "Cancel", }
                },
                ContentTitle = "title",
                ContentMessage = "Informative note:" +
                                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut pulvinar est, eget porttitor magna. Maecenas nunc elit, pretium nec mauris vel, cursus faucibus leo. Mauris consequat magna vel mi malesuada semper. Donec nunc justo, rhoncus vel viverra a, ultrices vel nibh. Praesent ut libero a nunc placerat vulputate. Morbi ullamcorper pharetra lectus, ut lobortis ex consequat sit amet. Vestibulum pellentesque quam at justo hendrerit, et tincidunt nisl mattis. Curabitur eu nibh enim.\n",
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = 500,
                MaxHeight = 800,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false,
            }).ShowAsPopupAsync(this);
        await MessageBoxManager.GetMessageBoxCustom(
            new MessageBoxCustomParams
            {
                ButtonDefinitions = new List<ButtonDefinition>{
                    new ButtonDefinition { Name = "OK", }
                },
                ContentTitle = "Result",
                ContentMessage = "You Selected:" + result,
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = 500,
                MaxHeight = 800,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false,
                CloseOnClickAway = true
            }).ShowAsPopupAsync(this);
    }
}