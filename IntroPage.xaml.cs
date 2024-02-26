using System.Windows;
using System.Windows.Controls;

namespace InstallApp
{
    /// <summary>
    /// Interaction logic for IntroPage.xaml
    /// </summary>
    public partial class IntroPage : Page
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            InstallLocationPage installLocationPage = new();
            this.NavigationService.Navigate(installLocationPage);
        }
    }
}
