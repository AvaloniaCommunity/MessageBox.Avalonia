using System;
using Avalonia.Threading;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels.Commands;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels;

public class MsBoxStandardViewModel : AbstractMsBoxViewModel
{
    public readonly ClickEnum _enterDefaultButton;
    public readonly ClickEnum _escDefaultButton;
    private readonly MsBoxStandardWindow _window;

    public MsBoxStandardViewModel(MessageBoxStandardParams @params, MsBoxStandardWindow msBoxStandardWindow) :
        base(@params, @params.Icon)
    {
        _enterDefaultButton = @params.EnterDefaultButton;
        _escDefaultButton = @params.EscDefaultButton;
        _window = msBoxStandardWindow;
        SetButtons(@params.ButtonDefinitions);
        ButtonClickCommand = new RelayCommand(o => ButtonClick(o.ToString()));
        EnterClickCommand = new RelayCommand(_ => EnterClick());
        EscClickCommand = new RelayCommand(_ => EscClick());
    }

    public bool IsOkShowed { get; private set; }
    public bool IsYesShowed { get; private set; }
    public bool IsNoShowed { get; private set; }
    public bool IsAbortShowed { get; private set; }
    public bool IsCancelShowed { get; private set; }
    public RelayCommand ButtonClickCommand { get; }
    public RelayCommand EnterClickCommand { get; }
    public RelayCommand EscClickCommand { get; }

    private void SetButtons(ButtonEnum paramsButtonDefinitions)
    {
        switch (paramsButtonDefinitions)
        {
            case ButtonEnum.Ok:
                IsOkShowed = true;
                break;
            case ButtonEnum.YesNo:
                IsYesShowed = true;
                IsNoShowed = true;
                break;
            case ButtonEnum.OkCancel:
                IsOkShowed = true;
                IsCancelShowed = true;
                break;
            case ButtonEnum.OkAbort:
                IsOkShowed = true;
                IsAbortShowed = true;
                break;
            case ButtonEnum.YesNoCancel:
                IsYesShowed = true;
                IsNoShowed = true;
                IsCancelShowed = true;
                break;
            case ButtonEnum.YesNoAbort:
                IsYesShowed = true;
                IsNoShowed = true;
                IsAbortShowed = true;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(paramsButtonDefinitions), paramsButtonDefinitions,
                    null);
        }
    }

    private void EscClick()
    {
        switch (_escDefaultButton)
        {
            case ClickEnum.Ok:
                ButtonClick(ButtonResult.Ok);
                return;
            case ClickEnum.Yes:
                ButtonClick(ButtonResult.Yes);
                return;
            case ClickEnum.No:
                ButtonClick(ButtonResult.No);
                return;
            case ClickEnum.Abort:
                ButtonClick(ButtonResult.Abort);
                return;
            case ClickEnum.Cancel:
                ButtonClick(ButtonResult.Cancel);
                return;
            case ClickEnum.None:
                ButtonClick(ButtonResult.None);
                return;
            case ClickEnum.Default:
            {
                if (IsCancelShowed)
                {
                    ButtonClick(ButtonResult.Cancel);
                    return;
                }

                if (IsAbortShowed)
                {
                    ButtonClick(ButtonResult.Abort);
                    return;
                }

                if (IsNoShowed)
                {
                    ButtonClick(ButtonResult.No);
                    return;
                }
            }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        ButtonClick(ButtonResult.None);
    }

    private void EnterClick()
    {
        switch (_enterDefaultButton)
        {
            case ClickEnum.Ok:
                ButtonClick(ButtonResult.Ok);
                return;
            case ClickEnum.Yes:
                ButtonClick(ButtonResult.Yes);
                return;
            case ClickEnum.No:
                ButtonClick(ButtonResult.No);
                return;
            case ClickEnum.Abort:
                ButtonClick(ButtonResult.Abort);
                return;
            case ClickEnum.Cancel:
                ButtonClick(ButtonResult.Cancel);
                return;
            case ClickEnum.None:
                ButtonClick(ButtonResult.None);
                return;
            case ClickEnum.Default:
            {
                if (IsOkShowed)
                {
                    ButtonClick(ButtonResult.Ok);
                    return;
                }

                if (IsYesShowed)
                {
                    ButtonClick(ButtonResult.Yes);
                    return;
                }
            }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public async void ButtonClick(string parameter)
    {
        await Dispatcher.UIThread.InvokeAsync(() =>
        {
            _window.ButtonResult = (ButtonResult)Enum.Parse(typeof(ButtonResult), parameter.Trim(), true);
            _window.Close();
        });
    }

    public async void ButtonClick(ButtonResult buttonResult)
    {
        await Dispatcher.UIThread.InvokeAsync(() =>
        {
            _window.ButtonResult = buttonResult;
            _window.Close();
        });
    }
}