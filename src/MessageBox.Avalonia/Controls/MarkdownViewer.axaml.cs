using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MessageBox.Avalonia.Controls
{
    public partial class MarkdownViewer : UserControl
    {
        private string _mdText;

        public string MdText
        {
            get => _mdText;
            set => _mdText = value;
        }
        public MarkdownViewer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
