using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

namespace Anilist_Manga_Updater_CSharp.GUI;

public partial class HeaderControl : UserControl
{
    public HeaderControl()
    {
        InitializeComponent();
        DataContext = Application.Current.MainWindow.DataContext;

        // Fix for the theme not being applied on startup
        ThemeToggleButton_Checked(this, new RoutedEventArgs());
        ThemeToggleButton_Unchecked(this, new RoutedEventArgs());
    }

    private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Clear();
        Application.Current.Resources.MergedDictionaries.Add(
            new ResourceDictionary { Source = new Uri("GUI/Themes/DarkTheme.xaml", UriKind.Relative) });

        SetButtonContent(HomeButton, "pack://application:,,,/GUI/Resources/home-icon-dark.png");
        SetButtonContent(SettingsButton, "pack://application:,,,/GUI/Resources/settings-icon-dark.png");
        SetButtonContent(ThemeToggleButton, "pack://application:,,,/GUI/Resources/light-mode-icon.png");
    }

    private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Clear();
        Application.Current.Resources.MergedDictionaries.Add(
            new ResourceDictionary { Source = new Uri("GUI/Themes/LightTheme.xaml", UriKind.Relative) });

        SetButtonContent(HomeButton, "pack://application:,,,/GUI/Resources/home-icon.png");
        SetButtonContent(SettingsButton, "pack://application:,,,/GUI/Resources/settings-icon.png");
        SetButtonContent(ThemeToggleButton, "pack://application:,,,/GUI/Resources/dark-mode-icon.png");
    }

    private void SetButtonContent(ToggleButton button, string imagePath)
    {
        button.Content = new Image
        {
            Source = new BitmapImage(new Uri(imagePath)),
            Width = 32,
            Height = 32,
            Margin = new Thickness(4)
        };
    }

    private void HomeButton_Click(object sender, RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).HomeButton_Click(sender, e);
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).SettingsButton_Click(sender, e);
    }

    private void StartButton_Click(object sender, RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).StartButton_Click(sender, e);
    }
}