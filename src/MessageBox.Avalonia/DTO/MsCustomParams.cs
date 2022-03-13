using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using System.Collections.Generic;

namespace MessageBox.Avalonia.DTO
{
    public class MsCustomParams : AbstractMessageBoxParams
    {
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

        private void UpdateLocal(AbstractMessageBoxParams @params)
        {
            WindowIcon = @params.WindowIcon;
            CanResize = @params.CanResize;
            ShowInCenter = @params.ShowInCenter;
            FontFamily = @params.FontFamily;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;
            Markdown = @params.Markdown;
            MinWidth = @params.MinWidth;
            MaxWidth = @params.MaxWidth;
            Width = @params.Width;
            MinHeight = @params.MinHeight;
            MaxHeight = @params.MaxHeight;
            Height = @params.Height;
            SizeToContent = @params.SizeToContent;
            WindowStartupLocation = @params.WindowStartupLocation;
            HasSystemDecorations = @params.HasSystemDecorations;
            Topmost = @params.Topmost;
        }
    }
}