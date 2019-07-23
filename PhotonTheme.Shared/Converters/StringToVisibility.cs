using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace PhotonTheme.Shared.Converters
{
    public class StringToVisibility : MarkupExtension, IValueConverter
    {
        public bool Inverted { private get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Inverted)
            {
                return string.IsNullOrEmpty((string)value) ? Visibility.Visible : Visibility.Collapsed;
            }

            return string.IsNullOrEmpty((string)value) ? Visibility.Collapsed : Visibility.Visible;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}