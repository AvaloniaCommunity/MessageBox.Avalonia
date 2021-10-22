using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    internal class MsBoxWindowBase<U, T> : IMsBoxWindow<T> where U : Window, IWindowGetResult<T>
    {
        private readonly U _window;
        public MsBoxWindowBase(U window)
        {
            _window = window;
        }
        /// <inheritdoc cref="IMsBoxWindow"/>
        public Task<T> Show()
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_window.GetResult()); };
            _window.Show();
            return tcs.Task;
        }

        /// <inheritdoc cref="IMsBoxWindow"/>
        public Task<T> Show(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_window.GetResult()); };
            _window.Show(ownerWindow);
            return tcs.Task;
        }

        /// <inheritdoc cref="IMsBoxWindow"/>
        public Task<T> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_window.GetResult()); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}
