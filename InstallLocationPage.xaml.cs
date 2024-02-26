using System.Windows;
using System.Windows.Controls;
using Presentation;

namespace InstallApp
{
    /// <summary>
    /// Interaction logic for InstallLocationPage.xaml
    /// </summary>
    public partial class InstallLocationPage : Page
    {
        private string? installationPath;

        public InstallLocationPage()
        {
            InitializeComponent();
        }

        private void locationBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFolderDialog dialog = new();

            dialog.Multiselect = false;
            dialog.Title = "Select a folder";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string fullPathToFolder = dialog.FolderName;
                string folderNameOnly = dialog.SafeFolderName;

                installationPath = fullPathToFolder;
                folderPath.Text = fullPathToFolder;
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            Presenter.InstallationPath = installationPath;
            InstallConfirmationPage installConfirmationPage = new();
            this.NavigationService.Navigate(installConfirmationPage);
            
        }
    }
}
