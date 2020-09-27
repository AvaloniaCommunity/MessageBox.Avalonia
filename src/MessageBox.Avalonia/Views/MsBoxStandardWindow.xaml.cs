using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;
using MessageBox.Avalonia.Views.Abstractions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxStandardWindow : ButtonResultWindow
    {
        public MsBoxStandardWindow()
        {
            InitializeComponent();
        }

        public MsBoxStandardWindow(Style style)
        {
            this.SetStyle(style);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}