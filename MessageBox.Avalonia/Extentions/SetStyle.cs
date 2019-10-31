using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Extentions
{
    public static class SetStyleExtension
    {
        public static void SetStyle(this Window window, Style style)
        {
            var styles = window.Styles;
            switch (style)
            {
                case Style.Windows:
                {
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/Button.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButton.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ButtonPointerOver.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Window/ColoredButtonPointerOver.xaml")});
                    break;
                }

                case Style.MacOs:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Button.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/MacOs/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButton.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ButtonPointerOver.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/ColoredButtonPointerOver.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Window.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/Window.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/TextBox.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/TextBox.xaml")});
                    break;
                }

                case Style.UbuntuLinux:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Button.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Ubuntu/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButton.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ButtonPointerOver.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/ColoredButtonPointerOver.xaml")});
                    break;
                }
                case Style.MintLinux:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MultyStyle/CornerRadius.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/Button.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Mint/Window/ColoredButton.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButton.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ButtonPointerOver.xaml")});
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/ColoredButtonPointerOver.xaml")});
                    break;
                }
                case Style.DarkMode:
                {
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/Button.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/Button.xaml")});

                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Dark/ButtonPointerOver.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/ButtonPointerOver.xaml")});

                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/Window.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/Window.xaml")});
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/TextBox.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/TextBox.xaml")});
                    break;
                }
            }
        }
    }
}