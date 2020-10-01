using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    public interface IMsBoxWindow<T>
    {
        Task<T> ShowDialog(Window ownerWindow);
        Task<T> Show();
        Task<T> Show(Window window);
    }
}