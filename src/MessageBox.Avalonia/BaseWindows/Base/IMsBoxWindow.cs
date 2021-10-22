using Avalonia.Controls;
using System.Threading.Tasks;

namespace MessageBox.Avalonia.BaseWindows.Base
{
    public interface IMsBoxWindow<T>
    {
        /// <summary>
        /// Open message box window as dialog window under owner
        /// </summary>
        /// <param name="ownerWindow"></param>
        /// <returns></returns>
        Task<T> ShowDialog(Window ownerWindow);
        /// <summary>
        /// Open message box window
        /// </summary>
        /// <returns></returns>
        Task<T> Show();
        /// <summary>
        /// Open message box window under owner window
        /// </summary>
        /// <param name="ownerWindow"></param>
        /// <returns></returns>
        Task<T> Show(Window ownerWindow);
    }
}