using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Views;

public class MsBoxStandardWindow : BaseWindow, IWindowGetResult<ButtonResult>
{
    public MsBoxStandardWindow() : base()
    {
        InitializeComponent();
    }

    public ButtonResult ButtonResult { get; set; } = ButtonResult.None;

    public ButtonResult GetResult() => ButtonResult;

    /// <inheritdoc />
    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        var okButton = this.FindControl<Button>("OkButton");
        okButton.Focus();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}