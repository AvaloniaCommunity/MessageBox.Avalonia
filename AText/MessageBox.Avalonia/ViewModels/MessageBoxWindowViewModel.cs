using System;
using System.IO;
using System.Reactive;
using System.Reflection;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;
using ReactiveUI;
using Button = MessageBox.Avalonia.Enums.Button;

namespace MessageBox.Avalonia.ViewModels
{
    public class MessageBoxWindowViewModel : ReactiveObject
    {
        public bool CanResize { get; private set; }

        public bool HasOkButton { get; private set; }

        public bool HasYesButton { get; private set; }

        public bool HasNoButton { get; private set; }

        public bool HasCancelButton { get; private set; }

        public bool HasAbortButton { get; private set; }

        public string ContentTitle { get; private set; }
        public string ContentHeader { get; private set; }
        public string ContentMessage { get; private set; }
        public Bitmap ImagePath { get; private set; }
        public int? MaxWidth { get; private set; }
        private MessageBoxWindow _window;
        
        public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }
       
        public MessageBoxWindowViewModel(MessageBoxWindowParams @params)
        {
            if (@params.Icon != Icon.None)
            {
                ImagePath = new Bitmap(AvaloniaLocator.Current.GetService<IAssetLoader>()
                    .Open(new Uri($" avares://MessageBox.Avalonia/Assets/{@params.Icon.ToString().ToLower()}.ico")));
            }
            MaxWidth = @params.MaxWidth;
            CanResize = @params.CanResize;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;
            _window = @params.Window;
            ButtonClickCommand = ReactiveCommand.Create<string>(ButtonClick);
            SetButtons(@params.Button);
        }

        private void SetButtons(Button buttons)
        {
            switch (buttons)
            {
                case Button.Ok:
                {
                    HasOkButton = true;
                    HasYesButton = false;
                    HasNoButton = false;
                    HasCancelButton = false;
                    HasAbortButton = false;
                    break;
                }
                case Button.YesNo:
                {
                    HasOkButton = false;
                    HasYesButton = true;
                    HasNoButton = true;
                    HasCancelButton = false;
                    HasAbortButton = false;
                    break;
                }
                case Button.OkCancel:
                {
                    HasOkButton = true;
                    HasYesButton = false;
                    HasNoButton = false;
                    HasCancelButton = true;
                    HasAbortButton = false;
                    break;
                }
                case Button.OkAbort:
                {
                    HasOkButton = true;
                    HasYesButton = false;
                    HasNoButton = false;
                    HasCancelButton = false;
                    HasAbortButton = true;
                    break;
                }
                case Button.YesNoCancel:
                {
                    HasOkButton = false;
                    HasYesButton = true;
                    HasNoButton = true;
                    HasCancelButton = true;
                    HasAbortButton = false;
                    break;
                }
                case Button.YesNoAbort:
                {
                    HasOkButton = false;
                    HasYesButton = true;
                    HasNoButton = true;
                    HasCancelButton = false;
                    HasAbortButton = true;
                    break;
                }
              
            }
        }
        
        void ButtonClick(string parameter)
        {
            switch (parameter.Trim().ToLower())
            {
                case "ok":
                {
                    _window.ButtonResult = MessageBoxResult.Ok;
                    break;
                }
                case "yes":
                {
                    _window.ButtonResult = MessageBoxResult.Yes;
                    break;
                }
                case "no":
                {
                    _window.ButtonResult = MessageBoxResult.No;
                    break;
                }
                case "cancel":
                {
                    _window.ButtonResult = MessageBoxResult.Cancel;
                    break;
                }
                case "abort":
                {
                    _window.ButtonResult = MessageBoxResult.Abort;
                    break;
                }

                default:
                {
                    _window.Close();
                    throw  new Exception("invalid button type");
                }
            }
            _window.Close();
        }

        public async Task Copy()
        {
           await AvaloniaLocator.Current.GetService<IClipboard>().SetTextAsync(ContentMessage);
        } 
    }
}