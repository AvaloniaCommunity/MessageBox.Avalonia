using System.Threading.Tasks;
using Avalonia.Controls;

namespace MessageBox.Avalonia.BaseWindows
{
    public interface IMsBoxWindow<T>
    {
        Task<T> ShowDialog(Window ownerWindow);
        Task<T> Show();
    }
}