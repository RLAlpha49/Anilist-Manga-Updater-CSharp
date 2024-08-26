using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

            var stackPanel = new StackPanel { Orientation = Orientation.Horizontal };
            var icon = new TextBlock { FontFamily = new FontFamily("Segoe MDL2 Assets"), Text = "\uE706", Width = 16, Height = 16, Margin = new Thickness(0, 0, 5, 0) };
            var text = new TextBlock { Text = "Light Mode", VerticalAlignment = VerticalAlignment.Center };
            stackPanel.Children.Add(icon);
            stackPanel.Children.Add(text);
            ThemeToggleButton.Content = stackPanel;
        }

        private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(
                new ResourceDictionary { Source = new Uri("LightTheme.xaml", UriKind.Relative) });

            var stackPanel = new StackPanel { Orientation = Orientation.Horizontal };
            var icon = new TextBlock { FontFamily = new FontFamily("Segoe MDL2 Assets"), Text = "\uE706", Width = 16, Height = 16, Margin = new Thickness(0, 0, 5, 0) };
            var text = new TextBlock { Text = "Dark Mode", VerticalAlignment = VerticalAlignment.Center };
            stackPanel.Children.Add(icon);
            stackPanel.Children.Add(text);
            ThemeToggleButton.Content = stackPanel;
        }
    }
}