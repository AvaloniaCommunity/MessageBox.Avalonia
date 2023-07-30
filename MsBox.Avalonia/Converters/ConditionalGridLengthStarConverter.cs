using System;
using System.Globalization;

using Avalonia.Controls;
using Avalonia.Data.Converters;

namespace MsBox.Avalonia.Converters
{
    public class ConditionalGridLengthStarConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return GridLength.Star;
            }
            else
            {
                return GridLength.Auto;
            }
        }

        public object ConvertBack(object value, Type targetType, object Parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}