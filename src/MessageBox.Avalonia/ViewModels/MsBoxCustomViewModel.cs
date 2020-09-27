using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxCustomViewModel : AbstractMsBoxViewModel<MsBoxCustomWindow>
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
        public string ContentMessage { get; }

        public MsBoxCustomViewModel(MessageBoxCustomParams @params, MsBoxCustomWindow msBoxCustomWindow) : base(@params)
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
                _window.ButtonResult = bd.Name;
                break;
            }

            _window.Close();

        }
    }
}