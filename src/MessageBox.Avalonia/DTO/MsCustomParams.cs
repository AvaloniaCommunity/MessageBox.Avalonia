using System.Collections.Generic;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;

namespace MessageBox.Avalonia.DTO
{
    public class MsCustomParams:AbstractMessageBoxParams
    {
        public Icon Icon { get; set; } = Icon.None;
        public Bitmap BitmapIcon { get; set; } 
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }

        public MsCustomParams(MessageBoxCustomParams @params)
        {
            Icon = @params.Icon;
            ButtonDefinitions = @params.ButtonDefinitions;
            WindowIcon = @params.WindowIcon;
            Style = @params.Style;
            CanResize = @params.CanResize;
            ShowInCenter = @params.ShowInCenter;
            FontFamily = @params.FontFamily;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;
            MaxWidth = @params.MaxWidth;
            WindowStartupLocation = @params.WindowStartupLocation;
        }

        public MsCustomParams(MessageBoxCustomParamsWithImage @params)
        {
            BitmapIcon = @params.Icon;
            ButtonDefinitions = @params.ButtonDefinitions;
            WindowIcon = @params.WindowIcon;
            Style = @params.Style;
            CanResize = @params.CanResize;
            ShowInCenter = @params.ShowInCenter;
            FontFamily = @params.FontFamily;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;
            MaxWidth = @params.MaxWidth;
            WindowStartupLocation = @params.WindowStartupLocation;
        }
    }
}