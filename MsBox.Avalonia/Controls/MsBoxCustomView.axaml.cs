using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Input.Platform;
using Avalonia.LogicalTree;
using Avalonia.Threading;

using MsBox.Avalonia.Base;
using MsBox.Avalonia.ViewModels;

namespace MsBox.Avalonia.Controls;

public partial class MsBoxCustomView : UserControl, IFullApi<string>, ISetCloseAction
{
    private string _buttonResult;
    private Action _closeAction;

    public MsBoxCustomView()
    {
        InitializeComponent();

        this.AttachedToVisualTree += (s, e) =>
        {
            Dispatcher.UIThread.Post(() =>
            {
                var defaultButton = this.GetLogicalDescendants()
                    .OfType<Button>()
                    .FirstOrDefault(b => b.IsDefault && b.IsVisible);

                if (defaultButton != null)
                {
                    defaultButton.Focus();
                }
            }, DispatcherPriority.Loaded);
        };
    }

    public void SetButtonResult(string bdName)
    {
        _buttonResult = bdName;
    }

    public string GetButtonResult()
    {
        return _buttonResult;
    }

    public Task Copy()
    {
        var clipboard = TopLevel.GetTopLevel(this).Clipboard;
        var text = ContentTextBox.SelectedText;
        if (string.IsNullOrEmpty(text))
        {
            text = (DataContext as AbstractMsBoxViewModel)?.ContentMessage;
        }
        if (clipboard is null || text is null)
            return Task.CompletedTask;
        var dataTransfer = new DataTransfer();
        dataTransfer.Add(DataTransferItem.CreateText(text));
        return clipboard.SetDataAsync(dataTransfer);
    }

    public void Close()
    {
        _closeAction?.Invoke();
    }

    public void CloseWindow(object sender, EventArgs eventArgs)
    {
        ((IClose)this).Close();
    }


    public void SetCloseAction(Action closeAction)
    {
        _closeAction = closeAction;
    }
}