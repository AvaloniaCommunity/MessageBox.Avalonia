using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxMarkdownViewModel : MsBoxStandardViewModel
    {
        public MsBoxMarkdownViewModel(MessageBoxStandardParams @params, MsBoxMarkdownWindow msBoxMarkdownWindow) :
            base(@params, msBoxMarkdownWindow)
        {
        }
    }
}