using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    internal class MsBoxWindowBase<U, T> : IMsBoxWindow<T> where U : Window, IWindowGetResult<T>
    {
        private U _window;
        public MsBoxWindowBase(U window)
        {
            _window = window;
        }
        public Task<T> Show()
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_window.GetResult()); };
            _window.Show();
            return tcs.Task;
        }

        public Task<T> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_window.GetResult()); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}
