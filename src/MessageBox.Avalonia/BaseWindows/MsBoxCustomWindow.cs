using System.Threading.Tasks;
using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using MsWindow = MessageBox.Avalonia.Views.MsBoxCustomWindow;

namespace MessageBox.Avalonia.BaseWindows
{
    public class MsBoxCustomWindow : IMsBoxWindow<string>
    {
        private MsWindow _window;

        public MsBoxCustomWindow(MsWindow window)
        {
            _window = window;
        }

        public Task<string> Show()
        {
            var tcs = new TaskCompletionSource<string>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.Show();
            return tcs.Task;
        }

        public Task<string> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<string>();
            _window.Closed += delegate { tcs.TrySetResult(_window.ButtonResult); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}