using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using MsBox.Avalonia.AttachadProperty;
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
        var vm = this.DataContext as MsBoxCustomViewModel;
        var text = vm.ContentMessage;
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