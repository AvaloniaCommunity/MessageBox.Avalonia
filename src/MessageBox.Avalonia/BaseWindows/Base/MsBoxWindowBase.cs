using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    internal class MsBoxWindowBase<U, T, R> : IMsBoxWindow<T> where U : Window where R : IResult<T>
    {
        private U _window;
        private readonly R _result;

        public MsBoxWindowBase(U window, R result)
        {
            _window = window;
            this._result = result;
        }

        public Task<T> Show()
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_result.GetResult()); };
            _window.Show();
            return tcs.Task;
        }

        public Task<T> ShowDialog(Window ownerWindow)
        {
            var tcs = new TaskCompletionSource<T>();
            _window.Closed += delegate { tcs.TrySetResult(_result.GetResult()); };
            _window.ShowDialog(ownerWindow);
            return tcs.Task;
        }
    }
}