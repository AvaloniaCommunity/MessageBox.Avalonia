using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Input;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using MessageBox.Avalonia.Controls;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Extensions;
using System;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.DTO;
using Style = MessageBox.Avalonia.Enums.Style;

namespace MessageBox.Avalonia.Views
{
    public class MsBoxHyperlinkWindow : Window, IWindowGetResult<ButtonResult>
    {
        public ButtonResult ButtonResult { get; set; } = ButtonResult.None;
        public MsBoxHyperlinkWindow()
        {
            this.InitializeComponent();
        }
        public MsBoxHyperlinkWindow(Style style)
        {

            this.SetStyle(style);
            InitializeComponent();
        }
        

        //More like a workaround because i dont know how to set it only with styles in .xaml file
        protected override void OnOpened(EventArgs e)
        {
            var res = this.Find<ItemsControl>("myItems");
            var temp = res?.GetLogicalChildren();
            if (temp != null)
            {
                foreach (var logical in temp)
                {
                    var item = (ContentPresenter) logical;
                    if (item.Content is Models.HyperlinkContent content && item.Child is Hyperlink hyperlink)
                    {
                        var isAliasEmpty = string.IsNullOrEmpty(content.Alias);
                        var isUrlEmpty = string.IsNullOrEmpty(content.Url);
                        if (isAliasEmpty && !isUrlEmpty)
                        {
                            hyperlink.Text = content.Url;
                        }
                        else if (!isAliasEmpty && isUrlEmpty)
                        {
                            hyperlink.Foreground = new SolidColorBrush(Color.Parse("Black"));
                            hyperlink.TextDecorations = new TextDecorationCollection();
                            hyperlink.Cursor = new Cursor(StandardCursorType.Arrow);
                        }
                    }
                }
            }
            base.OnOpened(e);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public ButtonResult GetResult() => ButtonResult;
    }
}
