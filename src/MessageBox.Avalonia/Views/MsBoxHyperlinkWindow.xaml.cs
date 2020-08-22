using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxHyperlinkWindow : Window
    {
        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;
        public MsBoxHyperlinkWindow()
        {
            this.InitializeComponent();
        }
        public MsBoxHyperlinkWindow(Style style)
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
