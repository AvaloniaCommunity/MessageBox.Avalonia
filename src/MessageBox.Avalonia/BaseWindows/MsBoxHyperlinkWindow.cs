using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using System.Threading.Tasks;
using MsWindow = MessageBox.Avalonia.Views.MsBoxHyperlinkWindow;

namespace MessageBox.Avalonia.BaseWindows
{
    public class MsBoxHyperlinkWindow : IMsBoxWindow<ButtonResult>
    {
        private MsWindow _window;

        public MsBoxHyperlinkWindow(MsWindow window)
        {
            _window = window;
        }

        public Task<ButtonResult> Show()
        {
            var tcs = new TaskCompletionSource<ButtonResult>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.Show();
            return tcs.Task;
        }

        public Task<ButtonResult> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<ButtonResult>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}
