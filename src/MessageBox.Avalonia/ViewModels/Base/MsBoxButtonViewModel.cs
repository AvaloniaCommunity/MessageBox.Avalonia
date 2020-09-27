using Avalonia.Controls;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBox.Avalonia.ViewModels.Base
{
    public class MsBoxButtonViewModel<T> : AbstractMsBoxViewModel<T> where T:ButtonResultWindow
    {
        public MsBoxButtonViewModel(AbstractMessageBoxParams @params) : base(@params)
        {
        }
        public bool IsOkShowed { get; private set; }
        public bool IsYesShowed { get; private set; }
        public bool IsNoShowed { get; private set; }
        public bool IsAbortShowed { get; private set; }
        public bool IsCancelShowed { get; private set; }
        public ButtonResult buttonResult = ButtonResult.None;
        internal void SetButtons(ButtonEnum paramsButtonDefinitions)
        {
            switch (paramsButtonDefinitions)
            {
                case ButtonEnum.Ok:
                    IsOkShowed = true;
                    break;
                case ButtonEnum.YesNo:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    break;
                case ButtonEnum.OkCancel:
                    IsOkShowed = true;
                    IsCancelShowed = true;
                    break;
                case ButtonEnum.OkAbort:
                    IsOkShowed = true;
                    IsAbortShowed = true;
                    break;
                case ButtonEnum.YesNoCancel:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    IsCancelShowed = true;
                    break;
                case ButtonEnum.YesNoAbort:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    IsAbortShowed = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(paramsButtonDefinitions), paramsButtonDefinitions,
                        null);
            }
        }
        public void ButtonClick(string parameter)
        {
            buttonResult = (ButtonResult)Enum.Parse(typeof(ButtonResult), parameter.Trim(), false);
            _window.Close();
        }
    }
}
