# MessageBox.Avalonia

Messagebox for AvaloniaUI
Now support all platforms as Xplat template

<img src="MsBox.Avalonia/icon.jpg" width="100" height="100">

To start you should install MessageBox.Avalonia NuGet package 
>   dotnet add package MessageBox.Avalonia 

[![nuget](https://img.shields.io/badge/nuget-blue)](https://www.nuget.org/packages/MessageBox.Avalonia/)
or download this repo.

![nuget](https://img.shields.io/nuget/dt/MessageBox.Avalonia?color=blue&label=downloads)

---

The easiest way to get started is this:

![](Images/standart-messagebox.png)

```cs 
var box = MessageBoxManager
          .GetMessageBoxStandard("Caption", "Are you sure you would like to delete appender_replace_page_1?",
                ButtonEnum.YesNo);

var result = await box.ShowAsync();
```

Other examples: ![wiki](https://github.com/AvaloniaCommunity/MessageBox.Avalonia/wiki/Examples)

Support: https://t.me/Avalonia


---

**Powered by**

<a href="https://www.jetbrains.com/?from=ABC">
<img width="400" alt="portfolio_view" src="https://github.com/CreateLab/MessageBox.Avalonia/blob/master/Images/jetbrains-variant-4.png" />
</a>
