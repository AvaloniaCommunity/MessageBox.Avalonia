using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxStandardWindow:Window 
    {
        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;
        
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