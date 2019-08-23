# MessageBox.Avalonia

Messagebox for AvaloniaUI

To start you shold install MessageBox.Avalonia Nuget package 
>   dotnet add package MessageBox.Avalonia 

[nuget.org](https://www.nuget.org/packages/MessageBox.Avalonia/)
or download this repo.

![wiki](https://gitlab.com/maindlab/messagebox.avalonia/wikis/home)


![trello progress](https://trello.com/b/oPRDrlaR/tasks)

( feature Cntr+C bind to copy ContentMessage to clipboard)




![](https://gitlab.com/maindlab/messagebox.avalonia/blob/master/Images/Screenshot_from_2019-08-23_16-05-14.png)



But you can create more powerfull widows, like this:

![](Images/Screenshot_from_2019-08-23_16-05-14.png)

```cs
var mbx  = new MessageBox.Avalonia.MessageBoxWindow("title","orem ipsum dolor sit amet, consectetur adipiscing elit, sed...");
    mbx.Show();
```

or this with defautlt buttons from enum:

![](Images/Screenshot_from_2019-08-23_16-39-27.png)

```cs
  var msgbox = new MessageBox.Avalonia.MessageBoxWindow(new MessageBoxParams
            {
                Button = ButtonEnum.OkAbort,
                ContentTitle = "title",
                ContentMessage = "Message",
                Icon = Icon.Plus,
                Style = Style.UbuntuLinux
            });
            msgbox.Show();
```

or like this, with custom buttons:

![](Images/Screenshot_from_2019-08-23_16-23-57.png)

```cs
   var m1 = MessageBox.Avalonia.MessageBoxWindow.CreateCustomWindow(new MessageBoxCustomParams
            {
                Style = Style.UbuntuLinux,
                ContentMessage = "Message",
                ButtonDefinitions = new []{new ButtonDefinition{Name = "My"},new ButtonDefinition{Name = "Buttons",Type = ButtonType.Colored} }
            });
            m1.Show();
```

