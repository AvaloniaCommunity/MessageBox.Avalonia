using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using ReactiveUI;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxInputViewModel : AbstractMsBoxViewModel<MsBoxInputWindow>
    {
        private string _inputText;
        public MsBoxInputViewModel(MessageBoxInputParams @params, MsBoxInputWindow msBoxInputWindow) : base(@params)
        {
            _window = msBoxInputWindow;
            ButtonDefinitions = @params.ButtonDefinitions;
            PassChar = @params.IsPassword ? '*' : (char?)null;
            WatermarkText = @params.WatermarkText;
        }

        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }

        public string InputText
        {
            get => _inputText;
            set => this.RaiseAndSetIfChanged(ref _inputText, value);
        }

        public char? PassChar { get; }
        public string WatermarkText { get; }
        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }
        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (parameter.Equals(bd.Name))
                {
                    _window.ButtonResult = bd.Name;
                    _window.MessageResult = InputText;
                    break;
                }
            }

            _window.Close();
            // Code for executing the command here.
        }
    }
}