using System.Threading.Tasks;
using Avalonia.Controls;
using MessageBox.Avalonia.DTO;
using MsWindow = MessageBox.Avalonia.Views.MsBoxInputWindow;
namespace MessageBox.Avalonia.BaseWindows
{
    public class MsBoxInputWindow:IMsBoxWindow<MessageWindowResultDTO>
    {
        private MsWindow _window;

        public MsBoxInputWindow(MsWindow window)
        {
            _window = window;
        }

        public Task<MessageWindowResultDTO> Show()
        {
            var tcs = new TaskCompletionSource<MessageWindowResultDTO>();
            _window.Closed += delegate { tcs.TrySetResult(new MessageWindowResultDTO(_window.ButtonResult,_window.MessageResult)); };
            _window.Show();
            return tcs.Task;
        }

        public Task<MessageWindowResultDTO> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<MessageWindowResultDTO>();
            _window.Closed += delegate { tcs.TrySetResult(new MessageWindowResultDTO(_window.ButtonResult,_window.MessageResult)); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }

    }
}