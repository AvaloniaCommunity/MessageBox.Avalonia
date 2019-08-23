using System;
using System.Collections.Generic;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.ViewModels;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia
{
    public partial class MessageBoxWindow
    {
        private MBoxWindow _window;

        private MessageBoxWindow(MessageBoxCustomParams dto)
        {
            _window = new MBoxWindow(dto.Style);
            var @params = new MessageBoxViewModelParams
            {
                Icon = dto.Icon,
                MaxWidth = dto.MaxWidth,
                CanResize = dto.CanResize,
                ContentTitle = dto.ContentTitle,
                ContentHeader = dto.ContentHeader,
                ContentMessage = dto.ContentMessage,
                ButtonDefinitions = dto.ButtonDefinitions,
                ShowInCenter = dto.ShowInCenter,
                Window = _window
            };
            _window.DataContext = new MessageBoxWindowViewModel(@params);
        }

        private static IEnumerable<ButtonDefinition> GetButtonsEnumerable(ButtonEnum buttonEnum)
        {
            var buttonList = new List<ButtonDefinition>();
            switch (buttonEnum)
            {
                case ButtonEnum.Ok:
                    buttonList.Add(new ButtonDefinition {Name = "Ok", Type = ButtonType.Colored, });
                    break;
                case ButtonEnum.YesNo:
                    buttonList.AddRange(new[]
                    {
                        new ButtonDefinition {Name = "Yes", Type = ButtonType.Default,},
                        new ButtonDefinition {Name = "No", Type = ButtonType.Default,}
                    });
                    break;
                case ButtonEnum.OkCancel:
                    buttonList.AddRange(new[]
                    {
                        new ButtonDefinition {Name = "Ok", Type = ButtonType.Colored, },
                        new ButtonDefinition {Name = "Cancel", Type = ButtonType.Default, }
                    });
                    break;
                case ButtonEnum.OkAbort:
                    buttonList.AddRange(new[]
                    {
                        new ButtonDefinition {Name = "Ok", Type = ButtonType.Colored,},
                        new ButtonDefinition {Name = "Abort", Type = ButtonType.Default,}
                    });
                    break;
                case ButtonEnum.YesNoCancel:
                    buttonList.AddRange(new[]
                    {
                        new ButtonDefinition {Name = "Yes", Type = ButtonType.Default,},
                        new ButtonDefinition {Name = "No", Type = ButtonType.Default, },
                        new ButtonDefinition {Name = "Cancel", Type = ButtonType.Default,},
                    });
                    break;
                case ButtonEnum.YesNoAbort:
                    buttonList.AddRange(new[]
                    {
                        new ButtonDefinition {Name = "Yes", Type = ButtonType.Default, },
                        new ButtonDefinition {Name = "No", Type = ButtonType.Default, },
                        new ButtonDefinition {Name = "Abort", Type = ButtonType.Default, },
                    });
                    break;
            }

            return buttonList;
        }


        private static MessageBoxCustomParams CreateCustomParams(MessageBoxParams @params)
        {
            var mbcp = new MessageBoxCustomParams
            {
                Icon = @params.Icon,
                Style = @params.Style,
                MaxWidth = @params.MaxWidth,
                CanResize = @params.CanResize,
                WindowIcon = @params.WindowIcon,
                ContentTitle = @params.ContentTitle,
                ContentHeader = @params.ContentHeader,
                ContentMessage = @params.ContentMessage,
                ButtonDefinitions = GetButtonsEnumerable(@params.Button)
            };
            return mbcp;
        }

        private static MessageBoxCustomParams CreateCustomParams(string title, string message)
        {
            var mbcp = new MessageBoxCustomParams
            {
              ContentTitle = title,
              ContentMessage = message,
              ButtonDefinitions = GetButtonsEnumerable(ButtonEnum.Ok)
            };
            return mbcp;
        }
    }
}