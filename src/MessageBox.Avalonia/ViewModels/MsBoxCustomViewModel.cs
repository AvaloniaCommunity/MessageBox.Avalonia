using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxCustomViewModel : AbstractMsBoxViewModel
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
        private readonly MsBoxCustomWindow _window;
        public string ContentMessage { get; }

        public MsBoxCustomViewModel(MsCustomParams @params, MsBoxCustomWindow msBoxCustomWindow) : base(@params,@params.Icon,@params.BitmapIcon)
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