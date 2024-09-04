using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AMU_Rewrite.GUI;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private bool _isDarkMode;

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        IsDarkMode = false;
        ContentUserControlInstance = new ContentUserControl();
        MainContentControl.Content = ContentUserControlInstance;
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

    public ContentUserControl ContentUserControlInstance { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}