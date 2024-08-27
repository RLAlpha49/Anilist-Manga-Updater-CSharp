using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AMU_Rewrite
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool _isDarkMode;
        public bool IsDarkMode
        {
            get => _isDarkMode;
            set
            {
                _isDarkMode = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            IsDarkMode = false;
        }

        private void ThemeToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            IsDarkMode = true;
            // Apply dark mode resources
        }

        private void ThemeToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            IsDarkMode = false;
            // Apply light mode resources
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}