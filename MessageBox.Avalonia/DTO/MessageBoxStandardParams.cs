using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.ViewModels;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxStandardParams : AbstractMessageBoxParams
    {
        public ButtonEnum ButtonDefinitions { get; set; } = ButtonEnum.Ok;

        public MsBoxStandardWindow Window { get; set; }
    }
}