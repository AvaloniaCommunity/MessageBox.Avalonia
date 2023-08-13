using Avalonia.Controls;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Controls;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.ViewModels;

namespace MsBox.Avalonia;

public static class MessageBoxManager
{
    public static IMsBox<string> GetMessageBoxCustom(MessageBoxCustomParams @params)
    {
        var msBoxCustomViewModel = new MsBoxCustomViewModel(@params);
        var msBoxCustomView = new MsBoxCustomView
        {
            DataContext = msBoxCustomViewModel
        };
        return new MsBox<MsBoxCustomView, MsBoxCustomViewModel, string>(msBoxCustomView, msBoxCustomViewModel);
    }

    public static IMsBox<ButtonResult> GetMessageBoxStandard(MessageBoxStandardParams @params)
    {
        var msBoxStandardViewModel = new MsBoxStandardViewModel(@params);
        var msBoxStandardView = new MsBoxStandardView
        {
            DataContext = msBoxStandardViewModel
        };
        return new MsBox<MsBoxStandardView, MsBoxStandardViewModel, ButtonResult>(msBoxStandardView,
            msBoxStandardViewModel);
    }

    /// <summary>
    /// Create instance of standard messagebox window
    /// </summary>
    /// <param name="title"> Windows title </param>
    /// <param name="text"> Text of messagebox body </param>
    /// <param name="enum"> Buttons of messagebox (default OK) </param>
    /// <param name="icon"> Icon of messagebox (default no icon) </param>
    /// <param name="windowStartupLocation"> Startup location of messagebox (default center screen) </param>
    /// <param name="style"></param>
    /// <returns></returns>
    /// <remarks>
    /// Recommended method for message box
    /// </remarks>
    public static IMsBox<ButtonResult> GetMessageBoxStandard(string title, string text,
        ButtonEnum @enum = ButtonEnum.Ok, Icon icon = Icon.None,
        WindowStartupLocation windowStartupLocation = WindowStartupLocation.CenterScreen) =>
        GetMessageBoxStandard(new MessageBoxStandardParams
        {
            ContentTitle = title,
            ContentMessage = text,
            ButtonDefinitions = @enum,
            Icon = icon,
            WindowStartupLocation = windowStartupLocation
        });
}