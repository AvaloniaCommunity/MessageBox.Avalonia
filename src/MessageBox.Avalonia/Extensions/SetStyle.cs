using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia.Enums;
using System;

namespace MessageBox.Avalonia.Extensions
{
    internal static class SetStyleExtension
    {
        internal static void SetStyle(this Window window, Style style)
        {
            var styles = window.Styles;
            string stylePath;
            switch (style)
            {
                case Style.Windows:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/Windows/Windows.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath))
                        { Source = new Uri(stylePath) });
                        break;
                    }

                case Style.MacOs:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/MacOs/MacOs.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath))
                        { Source = new Uri(stylePath) });
                        break;
                    }

                case Style.UbuntuLinux:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/Ubuntu/Ubuntu.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath)) { Source = new Uri(stylePath) });
                        break;
                    }
                case Style.MintLinux:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/Mint/Mint.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath)) { Source = new Uri(stylePath) });
                        break;
                    }
                case Style.DarkMode:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/Dark/Dark.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath)) { Source = new Uri(stylePath) });
                        break;
                    }
                case Style.RoundButtons:
                    {
                        stylePath = "avares://MessageBox.Avalonia/Styles/RoundButtons/RoundButtons.xaml";
                        styles.Add(new StyleInclude(new Uri(stylePath)) { Source = new Uri(stylePath) });
                        break;
                    }
            }
        }
    }
}