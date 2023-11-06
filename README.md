# MessageBox.Avalonia

Messagebox for AvaloniaUI
Now support all platforms as Xplat template

<img src="MsBox.Avalonia/icon.jpg" width="100" height="100">

To start you should install MessageBox.Avalonia NuGet package 
>   dotnet add package MessageBox.Avalonia 

[![nuget](https://img.shields.io/badge/nuget-blue)](https://www.nuget.org/packages/MessageBox.Avalonia/)
or download this repo.

[![nuget](https://img.shields.io/nuget/dt/MessageBox.Avalonia?color=blue&label=downloads)](https://www.nuget.org/packages/MessageBox.Avalonia/)

---

***Support creator:***  
<a href="https://www.buymeacoffee.com/fishenkovl3"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a pizza&emoji=🍕&slug=fishenkovl3&button_colour=5F7FFF&font_colour=ffffff&font_family=Cookie&outline_colour=000000&coffee_colour=FFDD00" /></a>

---

The easiest way to get started is this:

![](Images/standart-messagebox.png)

```cs 
  var box = MessageBoxManager
            .GetMessageBoxStandard("Caption", "Are you sure you would like to delete appender_replace_page_1?",
                ButtonEnum.YesNo);

        var result = await box.ShowAsync();
```
You have a lot of options how to show your messagebox:

`ShowAsync` -   Show messagebox depending on the type of application

      If application is SingleViewApplicationLifetime (Mobile or Browses) then show messagebox as popup
      
      If application is ClassicDesktopStyleApplicationLifetime (Desktop) then show messagebox as window

`ShowWindowAsync` - Show messagebox as window

`ShowWindowDialogAsync` - Show messagebox as window with owner

`ShowAsPopupAsync` - Show messagebox as popup


HyperLink with powerfull options:

```cs
MessageBoxManager.GetMessageBoxCustom(
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
```

Support: https://t.me/Avalonia

---

**Patrons:**

---

**Powered by**

<a href="https://www.jetbrains.com/?from=ABC">
<img width="400" alt="portfolio_view" src="https://github.com/CreateLab/MessageBox.Avalonia/blob/master/Images/jetbrains-variant-4.png" />
</a>
