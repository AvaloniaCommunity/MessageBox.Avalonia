using System.Collections.Generic;
using MsBox.Avalonia.Base;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Models;
using MsBox.Avalonia.ViewModels.Commands;

namespace MsBox.Avalonia.ViewModels;

public class MsBoxCustomViewModel : AbstractMsBoxViewModel, ISetFullApi<string>
{
    private IFullApi<string> _fullApi;

    public MsBoxCustomViewModel(MessageBoxCustomParams @params) : base(@params,
        @params.Icon, @params.ImageIcon)
    {
        ButtonDefinitions = @params.ButtonDefinitions;
        ButtonClickCommand = new RelayCommand(o => ButtonClick(o.ToString()));

        if (@params.HyperLinkParams == null) return;
        HyperLinkText = @params.HyperLinkParams.Text;
        HyperLinkCommand = new RelayCommand(_ => @params.HyperLinkParams.Action());
        IsHyperLinkVisible = true;
    }

    public RelayCommand HyperLinkCommand { get; }

    public void SetFullApi(IFullApi<string> fullApi)
    {
        _fullApi = fullApi;
        base.SetCopy(fullApi);
    }

    public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
    public RelayCommand ButtonClickCommand { get; }
    public string HyperLinkText { get; }
    
    public bool IsHyperLinkVisible { get; }

    public void ButtonClick(string parameter)
    {
        foreach (var bd in ButtonDefinitions)
        {
            if (!parameter.Equals(bd.Name)) continue;
            _fullApi.SetButtonResult(bd.Name);
            break;
        }

        _fullApi.Close();
    }
}