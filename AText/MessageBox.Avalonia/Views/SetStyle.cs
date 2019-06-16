using System;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.ViewModels;

namespace MessageBox.Avalonia.Views
{
    public partial class MessageBoxWindow : ReactiveWindow<MessageBoxWindowViewModel>
    {
        private void SetStyle(Style style)
        {
            switch (style)
            {
                case Style.Windows:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/OkButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/OkButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/OkButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/OkButtonPointerOver.xaml")});
                    break;
                }

                case Style.MacOs:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/MacOs/Window/OkButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/OkButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/OkButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/OkButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Window.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Window.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/TextBox.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/TextBox.xaml")});
                    break;
                }

                case Style.UbuntuLinux:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Ubuntu/Window/OkButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/OkButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/OkButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/OkButtonPointerOver.xaml")});
                    break;
                }
                case Style.MintLinux:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Mint/Window/OkButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/OkButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/OkButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/OkButtonPointerOver.xaml")});
                    break;
                }
                case Style.DarkMode:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/Button.xaml")});
                
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/ButtonPointerOver.xaml")});
                
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/Window.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/Window.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/TextBox.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/TextBox.xaml")});
                    break;
                }
            }
        }
    }
}