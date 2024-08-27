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
            DataContext = Application.Current.MainWindow.DataContext;
            
            // Fix for the theme not being applied on startup
            ThemeToggleButton_Checked(null, null);
            ThemeToggleButton_Unchecked(null, null);
        }

        private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary { Source = new Uri("DarkTheme.xaml", UriKind.Relative) });
            
            HomeButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/home-icon-dark.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
            
            SettingsButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/settings-icon-dark.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
            
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

            HomeButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/home-icon.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
            
            SettingsButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/settings-icon.png")),
                Width = 32,
                Height = 32,
                Margin = new Thickness(4)
            };
            
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