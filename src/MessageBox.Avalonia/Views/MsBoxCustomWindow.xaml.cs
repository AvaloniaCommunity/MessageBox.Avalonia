using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxCustomWindow:Window
    {
        public string ButtonResult { get; set; } = null;
        
        public MsBoxCustomWindow()
        {
           
            InitializeComponent();
        }
        public MsBoxCustomWindow(Style style)
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