using System.Windows;

namespace AMU_Rewrite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenContentWindow_Click(object sender, RoutedEventArgs e)
        {
            ContentWindow contentWindow = new ContentWindow();
            contentWindow.Show();
        }
    }
}