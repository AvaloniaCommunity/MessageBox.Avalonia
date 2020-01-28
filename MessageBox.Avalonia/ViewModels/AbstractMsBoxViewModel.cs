using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.ViewModels
{
    public abstract class AbstractMsBoxViewModel : ViewModelBase
    {
        public bool CanResize { get; }
        public bool HasHeader => !(string.IsNullOrEmpty(ContentHeader));
        public bool HasIcon => !(ImagePath is null);
        public string ContentTitle { get; }
        public string ContentHeader { get; }
        public string ContentMessage { get; }
        public Bitmap ImagePath { get; } = null;
        public int? MaxWidth { get; }

        public WindowStartupLocation LocationOfMyWindow { get; }

        public AbstractMsBoxViewModel(AbstractMessageBoxParams @params)
        {
            if (@params.Icon != Icon.None)
            {
                ImagePath = new Bitmap(AvaloniaLocator.Current.GetService<IAssetLoader>()
                    .Open(new Uri(
                        $" avares://MessageBox.Avalonia/Assets/{@params.Icon.ToString().ToLowerInvariant()}.ico")));
            }

            MaxWidth = @params.MaxWidth;
            CanResize = @params.CanResize;
            ContentTitle = @params.ContentTitle;
            ContentHeader = @params.ContentHeader;
            ContentMessage = @params.ContentMessage;

            LocationOfMyWindow = @params.WindowStartupLocation;
        }

        public async Task Copy()
        {
            await AvaloniaLocator.Current.GetService<IClipboard>().SetTextAsync(ContentMessage);
        }
    }
}