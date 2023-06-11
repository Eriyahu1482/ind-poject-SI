using ind_poject_SI.Core;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.ExercisesPages
{
    public partial class BreastPage : Page
    {
        public BreastPage()
        {
            InitializeComponent();
        }

        private void BenchH_Click(object sender, RoutedEventArgs e)
        {
            BenchHor.Visibility = Visibility.Visible;
            BenchVert.Visibility = Visibility.Hidden;
            BenchDum.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            hamer.Visibility = Visibility.Hidden;
        }

        private void BenchSl_Click(object sender, RoutedEventArgs e)
        {
            BenchVert.Visibility = Visibility.Visible;
            BenchHor.Visibility = Visibility.Hidden;
            BenchDum.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            hamer.Visibility = Visibility.Hidden;
        }

        private void BenchD_Click(object sender, RoutedEventArgs e)
        {
            BenchDum.Visibility = Visibility.Visible;
            BenchHor.Visibility = Visibility.Hidden;
            BenchVert.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            hamer.Visibility = Visibility.Hidden;
        }

        private void Push_ups_Click(object sender, RoutedEventArgs e)
        {
            Push.Visibility = Visibility.Visible;
            BenchDum.Visibility = Visibility.Hidden;
            BenchHor.Visibility = Visibility.Hidden;
            BenchVert.Visibility = Visibility.Hidden;
            hamer.Visibility = Visibility.Hidden;
        }

        private void Hamer_Click(object sender, RoutedEventArgs e)
        {
            hamer.Visibility = Visibility.Visible;
            Push.Visibility = Visibility.Hidden;
            BenchDum.Visibility = Visibility.Hidden;
            BenchHor.Visibility = Visibility.Hidden;
            BenchVert.Visibility = Visibility.Hidden;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new ExercrisesPage());
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            Push.Visibility = Visibility.Hidden;
            BenchDum.Visibility = Visibility.Hidden;
            BenchHor.Visibility = Visibility.Hidden;
            BenchVert.Visibility = Visibility.Hidden;
            hamer.Visibility = Visibility.Hidden;
        }
    }
}
