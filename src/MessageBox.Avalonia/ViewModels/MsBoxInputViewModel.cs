using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxInputViewModel : AbstractMsBoxViewModel
    {
        private readonly MsBoxInputWindow _window;
        
        public MsBoxInputViewModel(MessageBoxInputParams @params, MsBoxInputWindow msBoxInputWindow) : base(@params,@params.Icon)
        {
            _window = msBoxInputWindow;
            ButtonDefinitions = @params.ButtonDefinitions;

            Inputs = new List<object>();

            if (@params.IsPassword)
            {
                Inputs.Add(new PasswordInputViewModel(@params));
            }
            else
            {
                Inputs.Add(new InputViewModel(@params));
            }
        }

        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }

        public List<object> Inputs { get; }
        
        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }
        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (parameter.Equals(bd.Name))
                {
                    _window.ButtonResult = bd.Name;
                    _window.MessageResult = ((InputViewModel)Inputs[0]).InputText;
                    break;
                }
            }

            _window.Close();
            // Code for executing the command here.
        }
    }
}