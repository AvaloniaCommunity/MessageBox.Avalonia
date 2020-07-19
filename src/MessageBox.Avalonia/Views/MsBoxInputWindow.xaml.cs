using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxInputWindow : Window
    {
        public string ButtonResult { get; set; } = null;
        public string MessageResult { get; set; } = null;

        public MsBoxInputWindow()
        {
            InitializeComponent();
        }

        public MsBoxInputWindow(Style style)
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