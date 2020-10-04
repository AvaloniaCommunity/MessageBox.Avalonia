using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels.Base;
using MessageBox.Avalonia.Views;
using System;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxStandardViewModel : MsBoxButtonViewModel<MsBoxStandardWindow>,IResult<ButtonResult>
    {
        public MsBoxStandardViewModel(MessageBoxStandardParams @params, MsBoxStandardWindow msBoxStandardWindow) : base(@params)
        {
            ContentMessage = @params.ContentMessage;
            _window = msBoxStandardWindow;
            SetButtons(@params.ButtonDefinitions);
        }

        public ButtonResult ButtonResult { get; private set; }

        public void ButtonClick(string parameter)
        {
            ButtonResult = (ButtonResult)Enum.Parse(typeof(ButtonResult), parameter.Trim(), false);
            _window.Close();
        }

        public ButtonResult GetResult()
        {
            return ButtonResult;
        }
    }
}