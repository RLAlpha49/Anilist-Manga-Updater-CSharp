using System.Windows.Controls;

namespace Anilist_Manga_Updater_CSharp.GUI;

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