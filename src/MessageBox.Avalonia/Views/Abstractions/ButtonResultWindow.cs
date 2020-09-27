using Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBox.Avalonia.Views.Abstractions
{
    public class ButtonResultWindow:Window
    {
        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;
    }
}
