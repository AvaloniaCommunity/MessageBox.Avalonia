using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxStandardWindow : BaseWindow, IWindowGetResult<ButtonResult>
    {
        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;

        public MsBoxStandardWindow():base()
        {
            InitializeComponent();
        }

        public MsBoxStandardWindow(Style style):base()
        {
            
            this.SetStyle(style);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public ButtonResult GetResult() => ButtonResult;

        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);
            
            // Hack to fix scroll bar and limits
            SizeToContent = SizeToContent.Manual;
            Width--;
            Height--;
            
        }
    }
}