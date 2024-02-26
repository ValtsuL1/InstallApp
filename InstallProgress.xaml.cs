using Presentation;
using System.Windows;
using System.Windows.Controls;

namespace InstallApp
{
    /// <summary>
    /// Interaction logic for InstallProgress.xaml
    /// </summary>
    public partial class InstallProgress : Page
    {
        public InstallProgress()
        {
            InitializeComponent();
            Install();
        }

        private async void Install()
        {
            await Task.Run(() => Presenter.Install());
            label.Content = "Asennus valmis!";
            closeBtn.Visibility = Visibility.Visible;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
