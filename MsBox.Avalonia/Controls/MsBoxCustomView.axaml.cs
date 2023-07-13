using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using MsBox.Avalonia.AttachadProperty;
using MsBox.Avalonia.Base;
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
        throw new System.NotImplementedException();
    }

    public void Close()
    {
        _closeAction?.Invoke();
    }

    public void SetCloseAction(Action closeAction)
    {
        _closeAction = closeAction;
    }
    
}