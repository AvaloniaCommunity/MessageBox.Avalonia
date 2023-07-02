using System.Threading.Tasks;
using Avalonia.Controls;

namespace MsBox.Avalonia.Base;

public interface IMsBox<T>
{
     Task<T> ShowAsync();
     Task<T> ShowDialogAsync(Window owner);
     Task<T> ShowAsPopupAsync(ContentControl owner);
     Task<T> ShowAsPopupAsync(Window owner);
}