using System.Collections.Generic;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using ReactiveUI;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxInputViewModel : AbstractMsBoxViewModel
    {
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
        private string _inputText;

        public string InputText
        {
            get => _inputText;
            set => this.RaiseAndSetIfChanged(ref _inputText, value);
        }

        public string WatermarkText { get; }
        public char? PassChar { get; }

        private readonly MsBoxInputWindow _window;

        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }

        public MsBoxInputViewModel(MessageBoxInputParams @params) : base(@params)
        {
            _window = @params.Window;
            ButtonDefinitions = @params.ButtonDefinitions;
            PassChar = @params.IsPassword ? '*' : (char?) null;
            WatermarkText = @params.WatermarkText;
        }

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