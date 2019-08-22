using System.Windows;

namespace PhotonTheme.Controls
{
    public class FieldExtension
    {
        #region Corner Radius
        /// <summary>
        /// Controls the corner radius of the border container
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius", typeof(CornerRadius), typeof(FieldExtension), new PropertyMetadata(new CornerRadius(4.0)));

        public static void SetCornerRadius(DependencyObject element, CornerRadius value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        public static CornerRadius GetCornerRadius(DependencyObject element)
        {
            return (CornerRadius)element.GetValue(CornerRadiusProperty);
        }
        #endregion

        #region Title

        #endregion

        #region Placeholder

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.RegisterAttached("Placeholder", typeof(string), typeof(FieldExtension), new PropertyMetadata(default(string)));

        public static void SetPlaceholder(DependencyObject element, string value)
        {
            element.SetValue(PlaceholderProperty, value);
        }

        public static string GetPlaceholder(DependencyObject element)
        {
            return (string)element.GetValue(PlaceholderProperty);
        }

        #endregion

        #region IsError

        public static readonly DependencyProperty IsErrorProperty = DependencyProperty.RegisterAttached(
            "IsError", typeof(bool), typeof(FieldExtension), new PropertyMetadata(false));

        public static void SetIsError(DependencyObject element, bool value)
        {
            element.SetValue(IsErrorProperty, value);
        }

        public static bool GetIsError(DependencyObject element)
        {
            return (bool)element.GetValue(IsErrorProperty);
        }

        #endregion

        #region IsSuccess

        public static readonly DependencyProperty IsSuccessProperty = DependencyProperty.RegisterAttached(
            "IsSuccess", typeof(bool), typeof(FieldExtension), new PropertyMetadata(false));

        public static void SetIsSuccess(DependencyObject element, bool value)
        {
            element.SetValue(IsSuccessProperty, value);
        }

        public static bool GetIsSuccess(DependencyObject element)
        {
            return (bool)element.GetValue(IsSuccessProperty);
        }

        #endregion

    }
}
