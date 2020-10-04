using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxCustomViewModel : AbstractMsBoxViewModel<MsBoxCustomWindow>, IResult<string>
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
        public string ButtonResult { get; set; }

        public MsBoxCustomViewModel(MessageBoxCustomParams @params, MsBoxCustomWindow msBoxCustomWindow)
            : base(@params, msBoxCustomWindow)
        {
            ContentMessage = @params.ContentMessage;
            _window = msBoxCustomWindow;
            ButtonDefinitions = @params.ButtonDefinitions;
        }

        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (!parameter.Equals(bd.Name)) continue;
                ButtonResult = bd.Name;
                break;
            }

            _window.Close();
        }

        public string GetResult()
        {
            return ButtonResult;
        }
    }
}