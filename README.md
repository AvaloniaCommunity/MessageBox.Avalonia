# MessageBox.Avalonia

Messagebox for AvaloniaUI


![](Images/Untitled1.jpg)


To start you should install MessageBox.Avalonia NuGet package 
>   dotnet add package MessageBox.Avalonia 

[![nuget](https://img.shields.io/badge/1.1-nuget-blue)](https://www.nuget.org/packages/MessageBox.Avalonia/)
or download this repo.

![nuget](https://img.shields.io/nuget/dt/MessageBox.Avalonia?color=blue&label=downloads)

---

The easiest way to get started is this:

![](Images/stadard.png)

```cs 
var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
  .GetMessageBoxStandardWindow("title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
messageBoxStandardWindow.Show();
```

---

Or this, with default buttons from the default `ButtonEnum`:

![](Images/Base2.png)

```cs
var msBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
    .GetMessageBoxStandardWindow(new MessageBoxStandardParams{
        ButtonDefinitions = ButtonEnum.OkAbort,
        ContentTitle = "Title",
        ContentMessage = "Message",
        Icon = Icon.Plus,
        Style = Style.UbuntuLinux
    });
msBoxStandardWindow.Show();
```

---

Or like this, with custom buttons:

![](Images/custom.png)

```cs
 var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxCustomWindow(new MessageBoxCustomParams
                {
                    Style = Style.UbuntuLinux,
                    ContentMessage = "支持FontFamily",
                    FontFamily = "Microsoft YaHei,Simsun",
                    ButtonDefinitions = new[] {
                        new ButtonDefinition {Name = "My"},
                        new ButtonDefinition {Name = "Buttons", Type = ButtonType.Colored}
                    },
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                });
messageBoxCustomWindow.Show();
```

---

Or like this, with Markdown text:

![](Images/markdown.png)

```cs
var messageBoxMarkdownWindow = MessageBox.Avalonia.MessageBoxManager
    .GetMessageBoxCustomWindow(new MessageBoxCustomParams()
    {
        Icon = MessageBoxAvaloniaEnums.Icon.Info,
        ContentHeader = "Update is available! (not really)",
        ContentMessage = "## 🚀 Features\r\n\r\n" +
                            "- A cool feature\r\n\r\n" +
                            "## 📦 Dependencies\r\n\r\n" +
                            "- Bump antigravity from 1 to 2 @dependabot[bot]\r\n" +
                            "- Bump magic from 2 to 3 by @dependabot[bot]",
        Markdown = true,
        ButtonDefinitions = new[]
            {
                new ButtonDefinition { Name = "Update now", IsDefault = true },
                new ButtonDefinition { Name = "Maybe later", IsCancel = true }

            },
    });
messageBoxMarkdownWindow.Show();
```

---

And you may use your own images:

![](Images/customImage.png)

```cs
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
 messageBoxCustomWindow.Show();
```
---

Also you may use hyperlink boxes:

![](Images/link.png)


```cs
 var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxHyperlinkWindow(new MessageBoxHyperlinkParams()
            {
                CanResize = true,
                Style = MessageBoxAvaloniaEnums.Style.MacOs,
                HyperlinkContentProvider = new[]{
                    new HyperlinkContent { Alias = "dedede         ", Url = "https://avaloniaui.net/docs/styles/styles" },
                    new HyperlinkContent { Alias="edvyydebbvydebvyed         "},
                    new HyperlinkContent { Url= "https://avaloniaui.net/docs/styles/styles" }
                },
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ButtonDefinitions = MessageBoxAvaloniaEnums.ButtonEnum.Ok
            });
messageBoxCustomWindow.Show();
```

---

**Powered by**

<a href="https://www.jetbrains.com/?from=ABC">
<img width="400" alt="portfolio_view" src="https://github.com/CreateLab/MessageBox.Avalonia/blob/master/Images/jetbrains-variant-4.png" />
</a>
