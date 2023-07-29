using Avalonia.Controls;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MsBox.Avalonia.ViewModels
{
    /// <summary>
    /// ViewModel instances used in dessign mode
    /// </summary>
    internal static class DesignDataContexts
    {
        #region Standard box viewmodels
        public static MsBoxStandardViewModel StandardPlainViewModel { get; }
        public static MsBoxStandardViewModel StandardHyperlinkViewModel { get; }
        public static MsBoxStandardViewModel StandardInputViewModel { get; }
        public static MsBoxStandardViewModel StandardHyperlinkInputViewModel { get; }
        #endregion

        #region Custom box viewmodels
        public static MsBoxCustomViewModel CustomPlainViewModel { get; }
        public static MsBoxCustomViewModel CustomHyperlinkViewModel { get; }
        public static MsBoxCustomViewModel CustomInputViewModel { get; }
        public static MsBoxCustomViewModel CustomHyperlinkInputViewModel { get; }
        #endregion

        static DesignDataContexts()
        {
            StandardPlainViewModel = new MsBoxStandardViewModel(new MessageBoxStandardParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = ButtonEnum.OkCancel,
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen

            });

            StandardHyperlinkViewModel = new MsBoxStandardViewModel(new MessageBoxStandardParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = ButtonEnum.OkCancel,
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                HyperLinkParams = new HyperLinkParams { Text = "HyperLink text" }

            });

            StandardInputViewModel = new MsBoxStandardViewModel(new MessageBoxStandardParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = ButtonEnum.OkCancel,
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                InputParams= new InputParams { DefaultValue = "Input value", Label = "Label" }

            });

            StandardHyperlinkInputViewModel = new MsBoxStandardViewModel(new MessageBoxStandardParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = ButtonEnum.OkCancel,
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                HyperLinkParams = new HyperLinkParams { Text = "HyperLink text" },
                InputParams = new InputParams { DefaultValue = "Input value", Label = "Label" }

            });


            CustomPlainViewModel = new MsBoxCustomViewModel(new MessageBoxCustomParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = new ButtonDefinition[] 
                { 
                    new ButtonDefinition { Name = "Ok", IsDefault = true }, 
                    new ButtonDefinition { Name = "Cancel", IsCancel = true } 
                },
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen

            });

            CustomHyperlinkViewModel = new MsBoxCustomViewModel(new MessageBoxCustomParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = new ButtonDefinition[]
                {
                    new ButtonDefinition { Name = "Ok", IsDefault = true },
                    new ButtonDefinition { Name = "Cancel", IsCancel = true }
                },
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                HyperLinkParams = new HyperLinkParams { Text = "HyperLink text" }

            });

            CustomInputViewModel = new MsBoxCustomViewModel(new MessageBoxCustomParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = new ButtonDefinition[]
                {
                    new ButtonDefinition { Name = "Ok", IsDefault = true },
                    new ButtonDefinition { Name = "Cancel", IsCancel = true }
                },
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                InputParams = new InputParams { DefaultValue = "Input value", Label = "Label" }

            });

            CustomHyperlinkInputViewModel = new MsBoxCustomViewModel(new MessageBoxCustomParams
            {
                ContentTitle = "Title",
                ContentMessage = "Message",
                ButtonDefinitions = new ButtonDefinition[]
                {
                    new ButtonDefinition { Name = "Ok", IsDefault = true },
                    new ButtonDefinition { Name = "Cancel", IsCancel = true }
                },
                Icon = Icon.Info,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                HyperLinkParams = new HyperLinkParams { Text = "HyperLink text" },
                InputParams = new InputParams { DefaultValue = "Input value", Label = "Label" }

            });
        }
    }
}