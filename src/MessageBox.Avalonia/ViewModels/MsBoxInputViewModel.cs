using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using ReactiveUI;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxInputViewModel : AbstractMsBoxViewModel<MsBoxInputWindow>,IResult<MessageWindowResultDTO>
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
        public string ButtonResult { get; internal set; }
        public string MessageResult { get; internal set; }
        public char? PassChar { get; }
        public string WatermarkText { get; }
        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (parameter.Equals(bd.Name))
                {
                    ButtonResult = bd.Name;
                    MessageResult = InputText;
                    break;
                }
            }

            _window.Close();
            // Code for executing the command here.
        }

        public MessageWindowResultDTO GetResult()
        {
            return new MessageWindowResultDTO(MessageResult, ButtonResult);
        }
    }
}