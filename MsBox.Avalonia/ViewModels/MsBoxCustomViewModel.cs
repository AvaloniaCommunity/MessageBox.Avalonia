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
    }

    public void SetFullApi(IFullApi<string> fullApi)
    {
        _fullApi = fullApi;
        base.SetCopy(fullApi);
    }

    public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }

    #region Hyperlink properties
    public override RelayCommand HyperLinkCommand { get; internal set; }
    public override string HyperLinkText { get; internal set; }
    public override bool IsHyperLinkVisible { get; internal set; }
    #endregion

    #region Input properties
    public override string InputLabel { get; internal set; }
    public override string InputValue { get; set; }
    public override bool IsInputVisible { get; internal set; }
    #endregion

    public RelayCommand ButtonClickCommand { get; }

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