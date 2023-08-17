using System;
using System.Threading.Tasks;

using Avalonia.Controls;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.ViewModels;

namespace MsBox.Avalonia.Controls;

public partial class MsBoxStandardView : UserControl, IFullApi<ButtonResult>, ISetCloseAction
{
    private ButtonResult _buttonResult = ButtonResult.None;
    private Action _closeAction;

    public MsBoxStandardView()
    {
        InitializeComponent();
    }

    public void SetButtonResult(ButtonResult bdName)
    {
        _buttonResult = bdName;
    }

    public ButtonResult GetButtonResult()
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
        return clipboard?.SetTextAsync(text);
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