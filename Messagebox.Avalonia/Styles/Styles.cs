using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Media;

namespace ClassLibrary1.Styles
{
    public class Styles
    {
        private static  readonly Lazy<Styles> _instance = new Lazy<Styles>(()=> new Styles());
        public static Styles Instance => _instance.Value;
        private Styles(){}

        public Control WindowStyle(Button button)
        {
            if (button.Content.ToString().Trim() == "Ok")
            {
                button.Background = new SolidColorBrush(Color.FromArgb(0xFF,0,0xBC,0xF2));
                button.BorderBrush =new SolidColorBrush(Color.FromArgb(0xFF,0,0xBC,0xF2));
            }
               
            else
            {
                button.Background = Brushes.White;
                button.BorderThickness = new Thickness(1,1,1,1);
                button.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF,0,0xBC,0xF2));
                
            }

            return button;
        }

        public Control LinuxStyle(Button button)
        {
            var border = new Border();
            border.CornerRadius = new CornerRadius(10);
            button.Background = Brushes.Transparent;
            button.BorderBrush = Brushes.Transparent;
            border.Child = button;
            border.BorderThickness = new Thickness(1,1,1,1);
            if (button.Content.ToString().Trim() == "Ok")
            {
                border.Background = new SolidColorBrush(Color.FromArgb(0xFF,0xE9,0x54,0x20));
                border.BorderBrush = Brushes.Black;
            }
                
            else
            {
                border.Background = Brushes.White;
                border.BorderBrush = Brushes.Orange;
            }
            return border;
        }
        
    }
}