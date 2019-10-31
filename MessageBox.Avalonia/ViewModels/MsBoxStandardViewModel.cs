using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxStandardViewModel
    {
        public bool CanResize { get; private set; }
        public bool HasHeader { get; private set; } = true;
        public bool HasIcon { get; private set; } = true;
        public string ContentTitle { get; private set; }
        public string ContentHeader { get; private set; }
        public string ContentMessage { get; private set; }
        public Bitmap ImagePath { get; private set; }
        public int? MaxWidth { get; private set; }
        private MsBoxStandardWindow _window;

        public bool IsOkShowed { get; private set; } 
        public bool IsYesShowed { get; private set; }
        public bool IsNoShowed { get; private set; }
        public bool IsAbortShowed { get; private set; }
        public bool IsCancelShowed { get; private set; }
      
        public WindowStartupLocation LocationOfMyWindow { get; private set; } = WindowStartupLocation.Manual;
        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }

        public MsBoxStandardViewModel(MessageBoxStandardParams @params)
        {
            if (@params.Icon != Icon.None)
            {
                ImagePath = new Bitmap(AvaloniaLocator.Current.GetService<IAssetLoader>()
                    .Open(new Uri($" avares://MessageBox.Avalonia/Assets/{@params.Icon.ToString().ToLower()}.ico")));
            }
            else
                HasIcon = false;

            MaxWidth = @params.MaxWidth;
            CanResize = @params.CanResize;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;
            _window = @params.Window;
            SetButtons(@params.ButtonDefinitions);
            if (string.IsNullOrEmpty(ContentHeader))
                HasHeader = false;
            if (@params.ShowInCenter)
                LocationOfMyWindow = WindowStartupLocation.CenterScreen;
        }

        private void SetButtons(ButtonEnum paramsButtonDefinitions)
        {
            switch (paramsButtonDefinitions)
            {
                case ButtonEnum.Ok:
                    IsOkShowed = true;
                    break;
                case ButtonEnum.YesNo:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    break;
                case ButtonEnum.OkCancel:
                    IsOkShowed = true;
                    IsCancelShowed = true;
                    break;
                case ButtonEnum.OkAbort:
                    IsOkShowed = true;
                    IsAbortShowed = true;
                    break;
                case ButtonEnum.YesNoCancel:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    IsCancelShowed = true;
                    break;
                case ButtonEnum.YesNoAbort:
                    IsYesShowed = true;
                    IsNoShowed = true;
                    IsAbortShowed = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(paramsButtonDefinitions), paramsButtonDefinitions, null);
            }
        }

        public void ButtonClick(string parameter)
        {
            _window.ButtonResult = (ButtonResult) Enum.Parse(typeof(ButtonResult), parameter);
            _window.Close();
        }

        
        public async Task Copy()
        {
            await AvaloniaLocator.Current.GetService<IClipboard>().SetTextAsync(ContentMessage);
        }
    }
}