using System;
using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;
using ReactiveUI;

namespace MessageBox.Avalonia.Views
{
    public partial class MessageBoxWindow : ReactiveWindow<MessageBoxWindowViewModel>
    {
        public MessageBoxResult ButtonResult { get; set; } = MessageBoxResult.None;

        public MessageBoxWindow(Style style)
        {
            SetStyle(style);
            this.WhenActivated(disposables => { });
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}