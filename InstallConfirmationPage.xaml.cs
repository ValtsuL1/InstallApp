using System.Windows;
using System.Windows.Controls;
using Presentation;

namespace InstallApp
{
    /// <summary>
    /// Interaction logic for InstallConfirmationPage.xaml
    /// </summary>
    public partial class InstallConfirmationPage : Page
    {
        public InstallConfirmationPage()
        {
            InitializeComponent();
            folderPath.Text = Presenter.InstallationPath;
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            InstallProgress installProgress = new();
            this.NavigationService.Navigate(installProgress);
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
