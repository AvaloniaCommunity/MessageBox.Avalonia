using MessageBox.Avalonia.DTO;

namespace MessageBox.Avalonia.Models
{
    public class PasswordInputViewModel : InputViewModel
    {
        public PasswordInputViewModel(MessageBoxInputParams @params) : base(@params)
        {
            PassChar = '*';
        }
        
        public char? PassChar { get; }
    }
}