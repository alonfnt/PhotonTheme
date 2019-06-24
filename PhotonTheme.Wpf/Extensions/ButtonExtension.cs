using System.Windows;
using PhotonTheme.Wpf.PackIcon;

namespace PhotonTheme.Wpf.Extensions
{
    public class ButtonExtension
    {
        /// <summary>
        /// Controls the corner radius of the Button
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius", typeof(CornerRadius), typeof(ButtonExtension), new PropertyMetadata(new CornerRadius(2.0)));

        /// <summary>
        /// Controls the left PackIconType and its visibility
        /// </summary>
        public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
            "LeftIcon", typeof(PackIconKind), typeof(ButtonExtension), new PropertyMetadata(null));

        /// <summary>
        /// Controls the left PackIconType and its visibility
        /// </summary>
        public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
            "RightIcon", typeof(PackIconKind), typeof(ButtonExtension), new PropertyMetadata(null));

        public static readonly DependencyProperty RightIconVisibilityProperty = DependencyProperty.RegisterAttached(
            "RightIconVisibility", typeof(Visibility), typeof(ButtonExtension), new PropertyMetadata(Visibility.Collapsed));

        public static readonly DependencyProperty LeftIconVisibilityProperty = DependencyProperty.RegisterAttached(
            "LeftIconVisibility", typeof(Visibility), typeof(ButtonExtension), new PropertyMetadata(Visibility.Collapsed));

        public static void SetCornerRadius(DependencyObject element, CornerRadius value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        public static CornerRadius GetCornerRadius(DependencyObject element)
        {
            return (CornerRadius)element.GetValue(CornerRadiusProperty);
        }

        public static void SetLeftIcon(DependencyObject element, PackIconKind value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        public static PackIconKind GetLeftIcon(DependencyObject element)
        {
            return (PackIconKind)element.GetValue(LeftIconProperty);
        }

        public static void SetRightIcon(DependencyObject element, PackIconKind value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        public static PackIconKind GetRightIcon(DependencyObject element)
        {
            return (PackIconKind)element.GetValue(RightIconProperty);
        }

        public static void SetRightIconVisibility(DependencyObject element, Visibility value)
        {
            element.SetValue(RightIconVisibilityProperty, value);
        }

        public static Visibility GetRightIconVisibility(DependencyObject element)
        {
            return (Visibility)element.GetValue(RightIconVisibilityProperty);
        }

        public static void SetLeftIconVisibility(DependencyObject element, Visibility value)
        {
            element.SetValue(LeftIconVisibilityProperty, value);
        }

        public static Visibility GetLeftIconVisibility(DependencyObject element)
        {
            return (Visibility)element.GetValue(LeftIconVisibilityProperty);
        }
    }
}