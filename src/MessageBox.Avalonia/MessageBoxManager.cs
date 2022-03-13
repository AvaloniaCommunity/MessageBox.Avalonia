using Avalonia.Controls;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;
using CustomWindow = MessageBox.Avalonia.Views.MsBoxCustomWindow;
using HyperlinkWindow = MessageBox.Avalonia.Views.MsBoxHyperlinkWindow;
using InputWindow = MessageBox.Avalonia.Views.MsBoxInputWindow;
using StandardWindow = MessageBox.Avalonia.Views.MsBoxStandardWindow;

namespace MessageBox.Avalonia
{
    public static class MessageBoxManager
    {
        /// <summary>
        /// Create instance of custom messagebox window
        /// </summary>
        /// <param name="params"> Params for custom window </param>
        /// <returns></returns>
        public static IMsBoxWindow<string> GetMessageBoxCustomWindow(MessageBoxCustomParams @params)
        {
            var window = new CustomWindow();
            window.DataContext = new MsBoxCustomViewModel(new MsCustomParams(@params), window);
            return new MsBoxWindowBase<CustomWindow, string>(window);
        }

        /// <summary>
        /// Create instance of custom messagebox window (with image instead of default icon)
        /// </summary>
        /// <param name="params"> Params for custom window </param>
        /// <returns></returns>
        public static IMsBoxWindow<string> GetMessageBoxCustomWindow(MessageBoxCustomParamsWithImage @params)
        {
            var window = new CustomWindow();
            window.DataContext = new MsBoxCustomViewModel(new MsCustomParams(@params), window);
            return new MsBoxWindowBase<CustomWindow, string>(window);
        }

        /// <summary>
        /// Create instance of standard messagebox window
        /// </summary>
        /// <param name="params">Params for standard window</param>
        /// <returns></returns>
        public static IMsBoxWindow<ButtonResult> GetMessageBoxStandardWindow(MessageBoxStandardParams @params)
        {
            var window = new StandardWindow();
            window.DataContext = new MsBoxStandardViewModel(@params, window);
            return new MsBoxWindowBase<StandardWindow, ButtonResult>(window);
        }

        /// <summary>
        /// Create instance of hyperlink messagebox window
        /// </summary>
        /// <param name="params">Params for hyperlink window</param>
        /// <returns></returns>
        public static IMsBoxWindow<ButtonResult> GetMessageBoxHyperlinkWindow(MessageBoxHyperlinkParams @params)
        {
            var window = new HyperlinkWindow();
            window.DataContext = new MsBoxHyperlinkViewModel(@params, window);
            return new MsBoxWindowBase<HyperlinkWindow, ButtonResult>(window);
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
        public static IMsBoxWindow<ButtonResult> GetMessageBoxStandardWindow(string title, string text,
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

        /// <summary>
        /// Create instance of standard messagebox window
        /// </summary>
        /// <param name="params">Params for input window</param>
        /// <returns></returns>
        public static IMsBoxWindow<MessageWindowResultDTO> GetMessageBoxInputWindow(MessageBoxInputParams @params)
        {
            var window = new InputWindow();
            window.DataContext = new MsBoxInputViewModel(@params, window);
            return new MsBoxWindowBase<InputWindow, MessageWindowResultDTO>(window);
        }
    }
}