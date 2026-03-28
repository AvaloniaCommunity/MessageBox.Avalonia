using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Input;
using Avalonia.LogicalTree;
using Avalonia.Threading;

using MsBox.Avalonia.Base;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.ViewModels;

namespace MsBox.Avalonia.Controls;

public partial class MsBoxStandardView : UserControl, IFullApi<ButtonResult>, ISetCloseAction
{
    private ButtonResult _buttonResult = ButtonResult.None;
    private Action _closeAction;

    public MsBoxStandardView()
    {
        InitializeComponent();

        if (Application.Current.TryGetResource("EmbeddedMessageBoxViewLocator", out object? embeddedViewLocator))
        {
            var viewLocator = embeddedViewLocator as IDataTemplate;
            if (viewLocator is not null)
            {
                embeddedView.DataTemplates.Add(viewLocator);
            }
        }

        this.AttachedToVisualTree += (s, e) =>
        {
            Dispatcher.UIThread.Post(() =>
            {
                var defaultButton = this.GetLogicalDescendants()
                    .OfType<Button>()
                    .FirstOrDefault(b => b.IsDefault && b.IsVisible);

                if (defaultButton != null)
                {
                    defaultButton.Focus();
                }
            }, DispatcherPriority.Loaded);
        };
    }

    public void SetButtonResult(ButtonResult bdName)
    {
        _buttonResult = bdName;
    }

    public ButtonResult GetButtonResult()
    {
        return _buttonResult;
    }

    public Task Copy()
    {
        var clipboard = TopLevel.GetTopLevel(this).Clipboard;
        DataTransfer copier = new();
        if (string.IsNullOrEmpty(ContentTextBox.SelectedText))
        {
            copier.Add(DataTransferItem.CreateText(ContentTextBox.SelectedText));
        }
        return clipboard?.SetDataAsync(copier);
    }

    public void Close()
    {
        _closeAction?.Invoke();
    }

    public void CloseWindow(object sender, EventArgs eventArgs)
    {
        ((IClose)this).Close();
    }

    public void SetCloseAction(Action closeAction)
    {
        _closeAction = closeAction;
    }
}