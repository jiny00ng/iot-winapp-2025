using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMneu1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
                new Uri("/MenuPage1.xaml", UriKind.RelativeOrAbsolute) 
                );
        }

        private void BtnMneu2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
                new Uri("/MenuPage2.xaml", UriKind.RelativeOrAbsolute)
                );
        }

        private void BtnMneu3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(
                new Uri("/MenuPage3.xaml", UriKind.RelativeOrAbsolute)
                );
        }
    }
}