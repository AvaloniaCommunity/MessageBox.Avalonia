using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;


namespace MessageBox.Avalonia.Views
{
    public partial class MBoxWindow : Window
    {
        //TODO: find and replace all Colored to colored !!!
        private void SetStyle(Style style)
        {
            switch (style)
            {
                case Style.Windows:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButtonPointerOver.xaml")});
                    break;
                }

                case Style.MacOs:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/MacOs/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButtonPointerOver.xaml")});
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
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Ubuntu/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButtonPointerOver.xaml")});
                    break;
                }
                case Style.MintLinux:
                {
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Mint/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButton.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml")});
                    Styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButtonPointerOver.xaml")});
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