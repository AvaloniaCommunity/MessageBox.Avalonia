using System;
using System.Threading.Tasks;

using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Enums;

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
        throw new System.NotImplementedException();
    }

    public void Close()
    {
        _closeAction?.Invoke();
    }

    public void CloseWindow(object sender, WindowClosingEventArgs e)
    {
        ((IClose)this).Close();
    }

    public void SetCloseAction(Action closeAction)
    {
      _closeAction = closeAction;
    }
}