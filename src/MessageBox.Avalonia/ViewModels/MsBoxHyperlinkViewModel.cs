using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.ViewModels.Base;
using MessageBox.Avalonia.Views;
using System;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxHyperlinkViewModel : MsBoxButtonViewModel<MsBoxHyperlinkWindow>, IResult<ButtonResult>
    {
        public MsBoxHyperlinkViewModel(MessageBoxHyperlinkParams @params, MsBoxHyperlinkWindow msBoxHyperlinkWindow)
            : base(@params, msBoxHyperlinkWindow)
        {
            _window = msBoxHyperlinkWindow;
            HyperlinkContentProvider = @params.HyperlinkContentProvider;
            SetButtons(@params.ButtonDefinitions);
        }

        public IEnumerable<HyperlinkContent> HyperlinkContentProvider { get; set; }
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