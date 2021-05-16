using System.ComponentModel;
using System.Runtime.CompilerServices;
using MessageBox.Avalonia.DTO;

namespace MessageBox.Avalonia.Models
{
    public class InputViewModel :INotifyPropertyChanged
    {
        public InputViewModel(MessageBoxInputParams @params)
        {
            WatermarkText = @params.WatermarkText;
            AllowMultiline = @params.AllowMultiline;
            Header = @params.InputHeader;
        }
        
        private string _inputText;
        public string InputText
        {
            get => _inputText;
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }
        
        public bool AllowMultiline { get; }
        
        public string Header { get; }
        
        public string WatermarkText { get; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}