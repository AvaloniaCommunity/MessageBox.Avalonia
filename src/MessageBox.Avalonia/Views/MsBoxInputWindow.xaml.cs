using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxInputWindow : BaseWindow ,IWindowGetResult<MessageWindowResultDTO>
    {
        public string ButtonResult { get; set; } = null;
        public string MessageResult { get; set; } = null;

        public MessageWindowResultDTO GetResult() => new MessageWindowResultDTO(MessageResult, ButtonResult);

        public MsBoxInputWindow():base()
        {
            InitializeComponent();
        }

        public MsBoxInputWindow(Style style):base()
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