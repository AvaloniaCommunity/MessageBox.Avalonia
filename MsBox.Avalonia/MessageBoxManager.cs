using Avalonia.Controls;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;

namespace MsBox.Avalonia;

public class MessageBoxManager
{
    public static IMsBox<string> GetMessageBoxCustomWindow(MessageBoxCustomParams @params)
    {
        throw new System.NotImplementedException();
    }

    public static IMsBox<ButtonResult> GetMessageBoxStandardWindow(MessageBoxStandardParams @params)
    {
        throw new System.NotImplementedException();
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
    /// Recommended method for messadge box
    /// </remarks>
    public static IMsBox<ButtonResult> GetMessageBoxStandardWindow(string title, string text,
        ButtonEnum @enum = ButtonEnum.Ok, Icon icon = Icon.None,
        WindowStartupLocation windowStartupLocation = WindowStartupLocation.CenterScreen) =>
        GetMessageBoxStandardWindow(new MessageBoxStandardParams
        {
            ContentTitle = title,
            ContentMessage = text,
            ButtonDefinitions = @enum,
            Icon = icon,
            WindowStartupLocation = windowStartupLocation
        });
}