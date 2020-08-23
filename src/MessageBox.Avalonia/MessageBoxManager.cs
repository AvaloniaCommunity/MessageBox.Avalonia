using Avalonia.Controls;
using MessageBox.Avalonia.BaseWindows;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;
using CustomWindow = MessageBox.Avalonia.Views.MsBoxCustomWindow;
using HyperlinkWindow = MessageBox.Avalonia.Views.MsBoxHyperlinkWindow;
using InputWindow = MessageBox.Avalonia.Views.MsBoxInputWindow;
using MsBoxCustomWindow = MessageBox.Avalonia.BaseWindows.MsBoxCustomWindow;
using MsBoxHyperlinkWindow = MessageBox.Avalonia.BaseWindows.MsBoxHyperlinkWindow;
using MsBoxInputWindow = MessageBox.Avalonia.BaseWindows.MsBoxInputWindow;
using MsBoxStandardWindow = MessageBox.Avalonia.BaseWindows.MsBoxStandardWindow;
using StandardWindow = MessageBox.Avalonia.Views.MsBoxStandardWindow;

namespace MessageBox.Avalonia
{
    public static class MessageBoxManager
    {
        public static IMsBoxWindow<string> GetMessageBoxCustomWindow(MessageBoxCustomParams @params)
        {
            var window = new CustomWindow(@params.Style);
            @params.Window = window;
            window.DataContext = new MsBoxCustomViewModel(@params);
            return new MsBoxCustomWindow(window);
        }

        public static IMsBoxWindow<ButtonResult> GetMessageBoxStandardWindow(MessageBoxStandardParams @params)
        {
            var window = new StandardWindow(@params.Style);
            @params.Window = window;
            window.DataContext = new MsBoxStandardViewModel(@params);
            return new MsBoxStandardWindow(window);
        }
        public static IMsBoxWindow<ButtonResult> GetMessageBoxHyperlinkWindow(MessageBoxHyperlinkParams @params)
        {
            var window = new HyperlinkWindow(@params.Style) { DataContext = new MsBoxHyperlinkViewModel(@params) };
            @params.Window = window;
            return new MsBoxHyperlinkWindow(window);
        }
        public static IMsBoxWindow<ButtonResult> GetMessageBoxStandardWindow(string title, string text,
            ButtonEnum @enum = ButtonEnum.Ok, Icon icon = Icon.None,
            WindowStartupLocation windowStartupLocation = WindowStartupLocation.CenterScreen,
            Style style = Style.None) => GetMessageBoxStandardWindow(new MessageBoxStandardParams
            {
                ContentTitle = title,
                ContentMessage = text,
                ButtonDefinitions = @enum,
                Icon = icon,
                Style = style,
                WindowStartupLocation = windowStartupLocation
            });

        public static IMsBoxWindow<MessageWindowResultDTO> GetMessageBoxInputWindow(MessageBoxInputParams @params)
        {
            var window = new InputWindow(@params.Style);
            @params.Window = window;
            window.DataContext = new MsBoxInputViewModel(@params);
            return new MsBoxInputWindow(window);
        }
    }
}