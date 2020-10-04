using Avalonia.Controls;
using MessageBox.Avalonia.BaseWindows;
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
        public static IMsBoxWindow<string> GetMessageBoxCustomWindow(MessageBoxCustomParams @params)
        {
            var window = new CustomWindow(@params.Style);
            var vm=new MsBoxCustomViewModel(@params, window);
            window.DataContext = vm;
            return new MsBoxWindowBase<CustomWindow, string, MsBoxCustomViewModel>(window,vm);
        }

        public static IMsBoxWindow<ButtonResult> GetMessageBoxStandardWindow(MessageBoxStandardParams @params)
        {
            var window = new StandardWindow(@params.Style);
            var vm =new MsBoxStandardViewModel(@params, window);
            window.DataContext = vm;
            return new MsBoxWindowBase<StandardWindow, ButtonResult, MsBoxStandardViewModel>(window,vm);
        }
        public static IMsBoxWindow<ButtonResult> GetMessageBoxHyperlinkWindow(MessageBoxHyperlinkParams @params)
        {
            var window = new HyperlinkWindow(@params.Style);
            var vm =new MsBoxHyperlinkViewModel(@params, window);
            window.DataContext = vm;
            return new MsBoxWindowBase<HyperlinkWindow, ButtonResult, MsBoxHyperlinkViewModel>(window,vm);
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
            var vm =new MsBoxInputViewModel(@params, window);
            window.DataContext = vm;
            return new MsBoxWindowBase<InputWindow, MessageWindowResultDTO, MsBoxInputViewModel>(window, vm);
        }
    }
}