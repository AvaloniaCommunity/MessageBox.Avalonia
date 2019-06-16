using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Media;
using Avalonia.Platform;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;
using MessageBox.Avalonia.Views;
using ReactiveUI;
using Splat;
using Button = MessageBox.Avalonia.Enums.Button;

namespace MessageBox.Avalonia
{
    public class MessageBoxManager
    {
        private static MessageBoxManager _inctanse;

        public static MessageBoxManager Inctanse
        {
            get { return _inctanse ??= new MessageBoxManager(); }
        }

        private MessageBoxManager()
        {
        }

        private MessageBoxWindowParams ConvertToWindowParams(MessageBoxParams @params)
        {
            return new MessageBoxWindowParams
            {
                Button = @params.Button, Icon = @params.Icon, CanResize = @params.CanResize,
                ContentHeader = @params.ContentHeader, ContentMessage = @params.ContentMessage,
                ContentTitle = @params.ContentTitle, MaxWidth = @params.MaxWidth
            };
        }

        public Task<MessageBoxResult> Show(string title, string text, Button button = Button.Ok,
            Icon icons = Icon.None, Style style = Style.None)
        {
            return Show(new MessageBoxParams
                {ContentTitle = title,Button= button, ContentMessage = text, Icon = icons, Style = style});
        }

        public Task<MessageBoxResult> Show(MessageBoxParams @params)
        {
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            var mWindow = CreateWindow(@params, tcs);
            mWindow.Show();
            return tcs.Task;
        }

        public Task<MessageBoxResult> ShowDialog(Window parentWindow, string title, string text,
            Button button = Button.Ok,
            Icon icons = Icon.None, Style style = Style.None)
        {
            return ShowDialog(new MessageBoxParams
            {
                ContentTitle = title, ContentMessage = text,Button= button, Icon = icons, ParentWindow = parentWindow, Style = style
            });
        }

        public Task<MessageBoxResult> ShowDialog(MessageBoxParams @params)
        {
            var tcs = new TaskCompletionSource<MessageBoxResult>();
            var mWindow = CreateWindow(@params, tcs);
            mWindow.ShowDialog(@params.ParentWindow);
            return tcs.Task;
        }

        private MessageBoxWindow CreateWindow(MessageBoxParams @params, TaskCompletionSource<MessageBoxResult> tcs)
        {
            var mWindow = new MessageBoxWindow(@params.Style);
            if (@params.WindowIcon != null)
                mWindow.Icon = new WindowIcon(@params.WindowIcon);
            var p = ConvertToWindowParams(@params);
            p.Window = mWindow;
            mWindow.DataContext = new MessageBoxWindowViewModel(p);
            mWindow.Closed += delegate { tcs.TrySetResult(mWindow.ButtonResult); };
           
            return mWindow;
            
        }

      
    }
}