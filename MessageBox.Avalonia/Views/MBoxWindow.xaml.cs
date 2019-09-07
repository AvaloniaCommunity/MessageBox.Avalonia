using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Views
{
    public partial class MBoxWindow: Window
    {
        public string ButtonResult { get; set; } = null;

        public MBoxWindow()
        {
           
            InitializeComponent();
        }
        public MBoxWindow(Style style)
        {
            SetStyle(style);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}