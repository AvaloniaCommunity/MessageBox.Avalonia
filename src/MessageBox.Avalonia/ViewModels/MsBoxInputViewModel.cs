using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxInputViewModel : AbstractMsBoxViewModel
    {
        private readonly MsBoxInputWindow _window;
        private string _inputText;
        public char? PassChar { get; }
        public string WatermarkText { get; }

        public bool Multiline { get; set; }
        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }

        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }

        public string InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        public MsBoxInputViewModel(MessageBoxInputParams @params, MsBoxInputWindow msBoxInputWindow) : base(@params,@params.Icon)
        {
            _window = msBoxInputWindow;
            ButtonDefinitions = @params.ButtonDefinitions;
            PassChar = @params.IsPassword ? '*' : null;
            WatermarkText = @params.WatermarkText;
            Multiline = @params.Multiline;

            // Make sure there are default buttons on dialog
            if (ButtonDefinitions is null)
            {
                ButtonDefinitions = new[]
                {
                    new ButtonDefinition {Name = "Confirm", IsDefault = true, Type = ButtonType.Colored},
                    new ButtonDefinition {Name = "Cancel", IsCancel = true}
                };
            }

            if (Multiline) // Fill if multi-line
            {
                var grid = _window.FindControl<Grid>("ContentGrid");
                grid.RowDefinitions[0].Height = GridLength.Parse("*");
            }
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