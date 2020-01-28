using System.Threading.Tasks;
using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using MsWindow = MessageBox.Avalonia.Views.MsBoxStandardWindow;

namespace MessageBox.Avalonia.BaseWindows
{
    public class MsBoxStandardWindow : IMsBoxWindow<ButtonResult>
    {
        private MsWindow _window;

        public MsBoxStandardWindow(MsWindow window)
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