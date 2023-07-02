namespace MsBox.Avalonia.Base;

public interface IFullApi<T>:ICopy, IClose
{
    void SetButtonResult(T bdName);
    T GetButtonResult();
}