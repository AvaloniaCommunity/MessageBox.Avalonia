﻿using System;
using System.Collections.Generic;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.ViewModels.Commands;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels;

public class MsBoxHyperlinkViewModel : AbstractMsBoxViewModel
{
    private readonly MsBoxHyperlinkWindow _window;

    public MsBoxHyperlinkViewModel(MessageBoxHyperlinkParams @params, MsBoxHyperlinkWindow msBoxHyperlinkWindow) :
        base(@params, @params.Icon)
    {
        _window = msBoxHyperlinkWindow;
        HyperlinkContentProvider = @params.HyperlinkContentProvider;
        SetButtons(@params.ButtonDefinitions);
        ButtonClickCommand = new RelayCommand(o => ButtonClick(o.ToString()));
    }

    public bool IsOkShowed { get; private set; }
    public bool IsYesShowed { get; private set; }
    public bool IsNoShowed { get; private set; }
    public bool IsAbortShowed { get; private set; }
    public bool IsCancelShowed { get; private set; }

    public IEnumerable<HyperlinkContent> HyperlinkContentProvider { get; set; }
    public RelayCommand ButtonClickCommand { get; }

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

    public void ButtonClick(string parameter)
    {
        _window.ButtonResult = (ButtonResult)Enum.Parse(typeof(ButtonResult), parameter.Trim(), false);
        _window.Close();
    }
}