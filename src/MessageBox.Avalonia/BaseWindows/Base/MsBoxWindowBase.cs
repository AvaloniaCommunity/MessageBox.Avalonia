using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    internal class MsBoxWindowBase<U, T> : IMsBoxWindow<T> where U : Window
    {
        private U _window;
        private T _whatToSet;
        public MsBoxWindowBase(U window,T whatToSet)
        {
            _whatToSet = whatToSet;
            _window = window;
        }
        public Task<T> Show()
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_whatToSet); };
            _window.Show();
            return tcs.Task;
        }

        public Task<T> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_whatToSet); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}
