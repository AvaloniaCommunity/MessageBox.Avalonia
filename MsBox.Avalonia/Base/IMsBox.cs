using System.Threading.Tasks;
using Avalonia.Controls;

namespace MsBox.Avalonia.Base;

public interface IMsBox<T>
{
     Task<T> ShowAsync();
     Task<T> ShowWindowAsync();
     Task<T> ShowWindowDialogAsync(Window owner);
     Task<T> ShowAsPopupAsync(ContentControl owner);
     Task<T> ShowAsPopupAsync(Window owner);
     string InputValue { get; }
}