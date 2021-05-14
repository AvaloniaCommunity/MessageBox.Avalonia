using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Views;
using System;
using Avalonia.Threading;
using MessageBox.Avalonia.ViewModels.Commands;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxStandardViewModel : AbstractMsBoxViewModel
    {
        private readonly MsBoxStandardWindow _window;
        public bool IsOkShowed { get; private set; }
        public bool IsYesShowed { get; private set; }
        public bool IsNoShowed { get; private set; }
        public bool IsAbortShowed { get; private set; }
        public bool IsCancelShowed { get; private set; }
        public  RelayCommand ButtonClickCommand { get; }
        public RelayCommand EnterClickCommand { get; }
        public RelayCommand EscClickCommand { get; }

        public MsBoxStandardViewModel(MessageBoxStandardParams @params, MsBoxStandardWindow msBoxStandardWindow) :
            base(@params,@params.Icon)
        {
            _window = msBoxStandardWindow;
            SetButtons(@params.ButtonDefinitions);
            ButtonClickCommand = new RelayCommand(o => ButtonClick(o.ToString()));
            EnterClickCommand = new RelayCommand(o => EnterClick());
            EscClickCommand = new RelayCommand(o => EscClick());
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
                    throw new ArgumentOutOfRangeException(nameof(paramsButtonDefinitions), paramsButtonDefinitions,
                        null);
            }
        }

        private void EnterClick()
        {
            if (IsOkShowed)
            {
                ButtonClick("OK");
            }

            if (IsYesShowed)
            {
                ButtonClick("YES");
            }
        }

        private async void EscClick()
        {
            await Dispatcher.UIThread.InvokeAsync(() => _window.Close());

        }

        public async void ButtonClick(string parameter)
        {
            await Dispatcher.UIThread.InvokeAsync(() =>
            {
                _window.ButtonResult = (ButtonResult) Enum.Parse(typeof(ButtonResult), parameter.Trim(), true);
                _window.Close();
            });
        }
    }
}