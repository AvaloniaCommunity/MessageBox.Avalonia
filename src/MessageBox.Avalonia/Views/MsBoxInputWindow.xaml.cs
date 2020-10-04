using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxInputWindow : Window
    {
        public MsBoxInputWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}