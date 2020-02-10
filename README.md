# MessageBox.Avalonia

Messagebox for AvaloniaUI
for 0.9


![](Images/Capture.PNG)


To start you should install MessageBox.Avalonia Nuget package 
>   dotnet add package MessageBox.Avalonia 

[![nuget](https://img.shields.io/badge/nuget-9-lightblue)](https://www.nuget.org/packages/MessageBox.Avalonia/0.9.0)
or download this repo.

[![wiki](https://img.shields.io/badge/wiki-v%200.9-brightgreen)](https://github.com/CreateLab/MessageBox.Avalonia/wiki) - here you can find all Api.



The easiest way is:

![](Images/baseWind.png)

```cs 
var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("title","orem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
messageBoxStandardWindow.Show();
```

or this with defautlt buttons from enum:

![](Images/Base2.png)

```cs
            var msBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(new MessageBoxStandardParams{
                ButtonDefinitions = ButtonEnum.OkAbort,
                ContentTitle = "Title",
                ContentMessage = "Message",
                Icon = Icon.Plus,
                Style = Style.UbuntuLinux
            });
            msBoxStandardWindow.Show();
```

or like this, with custom buttons:

![](Images/Custom.png)

```cs
            var messageBoxCustomWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxCustomWindow(new MessageBoxCustomParams {
                Style = Style.UbuntuLinux,
                ContentMessage = "Message",
                ButtonDefinitions = new []{new ButtonDefinition{Name = "My"},new ButtonDefinition{Name = "Buttons",Type = ButtonType.Colored} }
            });
            messageBoxCustomWindow.Show();
```
**Powered by**


<img width="400" alt="portfolio_view" src="https://github.com/CreateLab/MessageBox.Avalonia/blob/master/Images/jetbrains-variant-4.png">

**Usages:**

[Lacmus](https://github.com/lizaalert/lacmus)

[SQRLDotNetClient](https://github.com/sqrldev/SQRLDotNetClient)

[OpenTabletDriver](https://github.com/InfinityGhost/OpenTabletDriver/tree/c4d823a11824abec3fb0f6d4f7182610aba5c9d8)

