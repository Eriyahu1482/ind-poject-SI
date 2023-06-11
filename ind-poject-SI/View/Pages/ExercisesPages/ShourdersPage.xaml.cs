using ind_poject_SI.Core;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.ExercisesPages
{
    public partial class ShourdersPage : Page
    {
        public ShourdersPage()
        {
            InitializeComponent();
        }
        private void BenchH_Click(object sender, RoutedEventArgs e)
        {
            smith.Visibility = Visibility.Visible;
            LiftingD.Visibility = Visibility.Hidden;
            BenchP.Visibility = Visibility.Hidden;
            HandD.Visibility = Visibility.Hidden;
            SwingD.Visibility = Visibility.Hidden;
        }

        private void BenchSl_Click(object sender, RoutedEventArgs e)
        {
            LiftingD.Visibility = Visibility.Visible;
            smith.Visibility = Visibility.Hidden;
            BenchP.Visibility = Visibility.Hidden;
            HandD.Visibility = Visibility.Hidden;
            SwingD.Visibility = Visibility.Hidden;
        }

        private void BenchD_Click(object sender, RoutedEventArgs e)
        {
            BenchP.Visibility = Visibility.Visible;
            smith.Visibility = Visibility.Hidden;
            LiftingD.Visibility = Visibility.Hidden;
            HandD.Visibility = Visibility.Hidden;
            SwingD.Visibility = Visibility.Hidden;
        }

        private void Push_ups_Click(object sender, RoutedEventArgs e)
        {
            HandD.Visibility = Visibility.Visible;
            BenchP.Visibility = Visibility.Hidden;
            smith.Visibility = Visibility.Hidden;
            LiftingD.Visibility = Visibility.Hidden;
            SwingD.Visibility = Visibility.Hidden;
        }

        private void Hamer_Click(object sender, RoutedEventArgs e)
        {
            SwingD.Visibility = Visibility.Visible;
            HandD.Visibility = Visibility.Hidden;
            BenchP.Visibility = Visibility.Hidden;
            smith.Visibility = Visibility.Hidden;
            LiftingD.Visibility = Visibility.Hidden;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new ExercrisesPage());
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            HandD.Visibility = Visibility.Hidden;
            BenchP.Visibility = Visibility.Hidden;
            smith.Visibility = Visibility.Hidden;
            LiftingD.Visibility = Visibility.Hidden;
            SwingD.Visibility = Visibility.Hidden;
        }
    }
}
