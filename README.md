# MessageBox.Avalonia

Messagebox for AvaloniaUI
for 0.9 preview


![](Images/Capture.PNG)


To start you shold install MessageBox.Avalonia Nuget package 
>   dotnet add package MessageBox.Avalonia 

[![nuget](https://img.shields.io/badge/nuget-v0.9--preview-blue)](https://www.nuget.org/packages/MessageBox.Avalonia/0.9.0-preview#)
or download this repo.

[![wiki](https://img.shields.io/badge/wiki-v%200.9-brightgreen)](https://gitlab.com/maindlab/messagebox.avalonia/wikis/home) - here you can find all Api.



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
Usages
[Lacmus](https://github.com/lizaalert/lacmus)
