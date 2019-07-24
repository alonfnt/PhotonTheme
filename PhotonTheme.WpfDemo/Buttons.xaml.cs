using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PhotonTheme.WpfDemo
{
    /// <summary>
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox?.SelectedItem == null) return;

            switch (combobox.SelectedIndex)
            {
                case 1:
                    ShowcaseButton.Foreground = Helper.Get<Brush>("DarkForegroundBrush");
                    ShowcaseButton.Background = Helper.Get<Brush>("PrimaryBrush");
                    break;
                case 2:
                    ShowcaseButton.Foreground = Helper.Get<Brush>("PrimaryBrush");
                    ShowcaseButton.Background = Helper.Get<Brush>("LightBrush");
                    break;
                default:
                    ShowcaseButton.Foreground = Helper.Get<Brush>("LightForegroundBrush");
                    ShowcaseButton.Background = Helper.Get<Brush>("MediumBrush");
                    break;
            }
        }

        private void SizeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox?.SelectedItem == null) return;

            switch (combobox.SelectedIndex)
            {
                case 0:
                    ShowcaseButton.FontSize = 16;
                    break;
                case 1:
                    ShowcaseButton.FontSize = 14;
                    break;
                default:
                    ShowcaseButton.FontSize = 11;
                    break;
            }
        }

        private void BackgroundComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox?.SelectedItem == null) return;
            if (combobox.Items[combobox.SelectedIndex] is ComboBoxItem comboBoxItem)
                ShowcaseButton.Background = Helper.Get<Brush>(comboBoxItem.Content.ToString());
        }

        private void ForegroundComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox?.SelectedItem == null) return;
            if (combobox.Items[combobox.SelectedIndex] is ComboBoxItem comboBoxItem)
                ShowcaseButton.Foreground = Helper.Get<Brush>(comboBoxItem.Content.ToString());
        }
    }

    public static class Helper
    {
        public static T Get<T>(string resourceName) where T : class
        {
            return Application.Current.TryFindResource(resourceName) as T;
        }
    }
}