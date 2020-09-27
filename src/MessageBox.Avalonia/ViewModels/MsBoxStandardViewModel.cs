using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels.Base;
using MessageBox.Avalonia.Views;
using System;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxStandardViewModel : MsBoxButtonViewModel<MsBoxStandardWindow>
    {
        public string ContentMessage { get; }
        public MsBoxStandardViewModel(MessageBoxStandardParams @params, MsBoxStandardWindow msBoxStandardWindow) : base(@params)
        {
            ContentMessage = @params.ContentMessage;
            _window = msBoxStandardWindow;
            SetButtons(@params.ButtonDefinitions);
        }

    }
}