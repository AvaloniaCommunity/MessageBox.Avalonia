using System.Threading.Tasks;
using Avalonia.Controls;

namespace MsBox.Avalonia.Base;

public interface IMsBox<T>
{
     /// <summary>
     /// Show messagebox depending on the type of application
     /// If application is SingleViewApplicationLifetime (Mobile or Browses) then show messagebox as popup
     /// If application is ClassicDesktopStyleApplicationLifetime (Desktop) then show messagebox as window
     /// </summary>
     /// <returns></returns>
     /// <exception cref="NotSupportedException"></exception>
     Task<T> ShowAsync();
     
     /// <summary>
     ///  Show messagebox as window
     /// </summary>
     /// <returns></returns>
     Task<T> ShowWindowAsync();
     
     /// <summary>
     ///  Show messagebox as window with owner
     /// </summary>
     /// <param name="owner">Window owner </param>
     /// <returns></returns>
     Task<T> ShowWindowDialogAsync(Window owner);
     
     /// <summary>
     ///  Show messagebox as popup
     /// </summary>
     /// <param name="owner"></param>
     /// <returns></returns>
     Task<T> ShowAsPopupAsync(ContentControl owner);
     
     /// <summary>
     /// Show messagebox as popup with owner
     /// </summary>
     /// <param name="owner"></param>
     /// <returns></returns>
     Task<T> ShowAsPopupAsync(Window owner);
     
     string InputValue { get; }
}