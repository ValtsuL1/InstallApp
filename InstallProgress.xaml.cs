using Presentation;
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
