using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxCustomWindow : Window
    {
        public MsBoxCustomWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}