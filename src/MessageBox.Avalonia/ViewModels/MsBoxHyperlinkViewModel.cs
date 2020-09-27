using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.ViewModels.Base;
using MessageBox.Avalonia.Views;
using System;
using System.Collections.Generic;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxHyperlinkViewModel : MsBoxButtonViewModel<MsBoxHyperlinkWindow>
    {

        public MsBoxHyperlinkViewModel(MessageBoxHyperlinkParams @params, MsBoxHyperlinkWindow msBoxHyperlinkWindow) : base(@params)
        {
            _window = msBoxHyperlinkWindow;
            HyperlinkContentProvider = @params.HyperlinkContentProvider;
            SetButtons(@params.ButtonDefinitions);
        }
      
        public IEnumerable<HyperlinkContent> HyperlinkContentProvider { get; set; }
        
    }
}
