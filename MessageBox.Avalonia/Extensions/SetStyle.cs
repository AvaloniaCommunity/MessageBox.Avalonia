using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.Extensions
{
    internal static class SetStyleExtension
    {
        internal static void SetStyle(this Window window, Style style)
        {
            var styles = window.Styles;
            switch (style)
            {
                case Style.Windows:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Windows/Windows.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Windows/Windows.xaml")});
                    break;
                }

                case Style.MacOs:
                {
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/MacOs/MacOs.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/MacOs/MacOs.xaml")});
                    break;
                }

                case Style.UbuntuLinux:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Ubuntu.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Ubuntu/Ubuntu.xaml")});
                    break;
                }
                case Style.MintLinux:
                {
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Mint/Mint.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Mint/Mint.xaml")});
                    break;
                }
                case Style.DarkMode:
                {
                    styles.Add(new StyleInclude(new Uri("avares://MessageBox.Avalonia/Styles/Dark/Dark.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/Dark/Dark.xaml")});
                    break;
                }
                case Style.RoundButtons:
                {
                    styles.Add(new StyleInclude(
                            new Uri("avares://MessageBox.Avalonia/Styles/RoundButtons/RoundButtons.xaml"))
                        {Source = new Uri("avares://MessageBox.Avalonia/Styles/RoundButtons/RoundButtons.xaml")});
                    break;
                }
            }
        }
    }
}