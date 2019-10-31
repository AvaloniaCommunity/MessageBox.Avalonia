using MessageBox.Avalonia.BaseWindows;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;
using CustomWindow = MessageBox.Avalonia.Views.MsBoxCustomWindow;
using StandardWindow = MessageBox.Avalonia.Views.MsBoxStandardWindow;

namespace MessageBox.Avalonia
{
    public static class MessageBoxManager
    {
        public static MsBoxCustomWindow GetMessageBoxCustomWindow(MessageBoxCustomParams @params) =>
            new MsBoxCustomWindow(new CustomWindow(@params.Style) {DataContext = new MsBoxCustomViewModel(@params)});

        public static MsBoxStandardWindow GetMessageBoxStandardWindow(MessageBoxStandardParams @params) =>
            new MsBoxStandardWindow(new StandardWindow(@params.Style)
                {DataContext = new MsBoxStandardViewModel(@params)});

        public static MsBoxStandardWindow GetMessageBoxStandardWindow(string title, string text,
            ButtonEnum @enum = ButtonEnum.Ok, Icon icon = Icon.Avalonia,
            Style style = Style.None) => GetMessageBoxStandardWindow(new MessageBoxStandardParams
            {ContentTitle = title, ContentMessage = text, ButtonDefinitions = @enum, Icon = icon, Style = style});
    }
}