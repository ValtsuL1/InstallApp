using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
