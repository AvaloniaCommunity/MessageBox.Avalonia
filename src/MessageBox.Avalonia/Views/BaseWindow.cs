using Avalonia.Controls;
using Avalonia.Threading;

namespace MessageBox.Avalonia.Views
{
    public class BaseWindow : Window

    {
        public BaseWindow()
        {
            ShowInTaskbar = false;
            CanResize = false;
        }

        public async void CloseSafe()
        {
            await Dispatcher.UIThread.InvokeAsync(Close);
        }
    }
}