using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.Models;

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
        throw new System.NotImplementedException();
    }

    private void Custom_PopUp_OnClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Custom_MarkDown_OnClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}