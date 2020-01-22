using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxCustomViewModel : ViewModelBase
    {
        public bool CanResize { get;  }
        public bool HasHeader { get;  } = true;
        public bool HasIcon { get;  } = true;
        public string ContentTitle { get;  }
        public string ContentHeader { get; }
        public string ContentMessage { get; }
        public Bitmap ImagePath { get; }
        public int? MaxWidth { get;}
        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; private set; }
        private MsBoxCustomWindow _window;

        public WindowStartupLocation LocationOfMyWindow { get; private set; } = WindowStartupLocation.Manual;
        // public ReactiveCommand<string, Unit> ButtonClickCommand { get; private set; }

        public MsBoxCustomViewModel(MessageBoxCustomParams @params)
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
            ButtonDefinitions = @params.ButtonDefinitions;
            if (string.IsNullOrEmpty(ContentHeader))
                HasHeader = false;
            if (@params.ShowInCenter)
                LocationOfMyWindow = WindowStartupLocation.CenterScreen;
        }

        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (parameter.Equals(bd.Name))
                {
                    _window.ButtonResult = bd.Name;
                    break;
                }
            }

            _window.Close();
            // Code for executing the command here.
        }

        public async Task Copy()
        {
            await AvaloniaLocator.Current.GetService<IClipboard>().SetTextAsync(ContentMessage);
        }
    }
}