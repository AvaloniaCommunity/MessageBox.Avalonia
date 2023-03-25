using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;

namespace MessageBox.Avalonia.Views;

public class MsBoxInputWindow : BaseWindow, IWindowGetResult<MessageWindowResultDTO>
{
    public MsBoxInputWindow() : base()
    {
        InitializeComponent();
    }

    public string ButtonResult { get; set; } = null;
    public string MessageResult { get; set; } = null;

    public MessageWindowResultDTO GetResult() => new MessageWindowResultDTO(MessageResult, ButtonResult);

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}