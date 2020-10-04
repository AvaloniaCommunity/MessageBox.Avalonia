using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxStandardWindow : Window
    {
        public MsBoxStandardWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}