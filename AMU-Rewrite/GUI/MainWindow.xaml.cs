using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AMU_Rewrite.GUI;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private bool _isDarkMode;
    private bool _isHomeContentOpen;

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        IsDarkMode = false;
        ContentUserControlInstance = new ContentUserControl();
        MainContentControl.Content = ContentUserControlInstance;
        IsHomeContentOpen = true;
    }

    public bool IsDarkMode
    {
        get => _isDarkMode;
        set
        {
            _isDarkMode = value;
            OnPropertyChanged();
        }
    }

    public bool IsHomeContentOpen
    {
        get => _isHomeContentOpen;
        set
        {
            _isHomeContentOpen = value;
            OnPropertyChanged();
        }
    }

    private ContentUserControl ContentUserControlInstance { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public void HomeButton_Click(object sender, RoutedEventArgs e)
    {
        MainContentControl.Content = new HomeContent();
        IsHomeContentOpen = true;
    }

    public void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        MainContentControl.Content = new SettingsContent();
        IsHomeContentOpen = false;
    }

    public void StartButton_Click(object sender, RoutedEventArgs e)
    {
        HomeButton_Click(sender, e);
        // Start Logic Will Go Here
    }
}