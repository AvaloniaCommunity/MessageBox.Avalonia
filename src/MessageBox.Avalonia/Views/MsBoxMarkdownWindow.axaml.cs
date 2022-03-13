using Avalonia.Markup.Xaml;

namespace MessageBox.Avalonia.Views
{
    public partial class MsBoxMarkdownWindow : MsBoxStandardWindow
    {
        public MsBoxMarkdownWindow() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
