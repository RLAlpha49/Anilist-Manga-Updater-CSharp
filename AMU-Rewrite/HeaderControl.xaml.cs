using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AMU_Rewrite
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary { Source = new Uri("DarkTheme.xaml", UriKind.Relative) });

            ThemeToggleButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/light-mode-icon.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
        }

        private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary { Source = new Uri("LightTheme.xaml", UriKind.Relative) });

            ThemeToggleButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/dark-mode-icon.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
        }
    }
}