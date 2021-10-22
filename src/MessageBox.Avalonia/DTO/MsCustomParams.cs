using System.Collections.Generic;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;

namespace MessageBox.Avalonia.DTO
{
    public class MsCustomParams : AbstractMessageBoxParams
    {
        /// <summary>
        /// Messagebox icon
        /// </summary>
        public Icon Icon { get; set; } = Icon.None;
        /// <summary>
        /// Messagebox image
        /// </summary>
        public Bitmap BitmapIcon { get; set; }
        /// <summary>
        /// Buttons
        /// </summary>
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; set; }

        public MsCustomParams(MessageBoxCustomParams @params)
        {
            Icon = @params.Icon;
            ButtonDefinitions = @params.ButtonDefinitions;
            UpdateLocal(@params);
        }

        public MsCustomParams(MessageBoxCustomParamsWithImage @params)
        {
            BitmapIcon = @params.Icon;
            ButtonDefinitions = @params.ButtonDefinitions;
            UpdateLocal(@params);
        }

        private void UpdateLocal(AbstractMessageBoxParams @params)
        {
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
            Topmost = @params.Topmost;
        }
    }
}