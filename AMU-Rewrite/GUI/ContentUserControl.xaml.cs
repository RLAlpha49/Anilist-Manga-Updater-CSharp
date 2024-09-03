using System;
using System.Windows.Controls;

namespace AMU_Rewrite.GUI
{
    public partial class ContentUserControl : UserControl
    {
        public ContentUserControl()
        {
            InitializeComponent();
            SetContent(new HomeContent());
        }

        public void SetContent(UserControl content)
        {
            MainContentControl.Content = content;
        }
    }
}