using ind_poject_SI.Core;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.ExercisesPages
{
    public partial class ArmsPage : Page
    {
        public ArmsPage()
        {
            InitializeComponent();
        }
        private void BenchH_Click(object sender, RoutedEventArgs e)
        {
            BarelL.Visibility = Visibility.Visible;
            Ham.Visibility = Visibility.Hidden;
            FrenchB.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            Scot.Visibility = Visibility.Hidden;
        }

        private void BenchSl_Click(object sender, RoutedEventArgs e)
        {
            Ham.Visibility = Visibility.Visible;
            BarelL.Visibility = Visibility.Hidden;
            FrenchB.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            Scot.Visibility = Visibility.Hidden;
        }

        private void BenchD_Click(object sender, RoutedEventArgs e)
        {
            FrenchB.Visibility = Visibility.Visible;
            BarelL.Visibility = Visibility.Hidden;
            Ham.Visibility = Visibility.Hidden;
            Push.Visibility = Visibility.Hidden;
            Scot.Visibility = Visibility.Hidden;
        }

        private void Push_ups_Click(object sender, RoutedEventArgs e)
        {
            Push.Visibility = Visibility.Visible;
            FrenchB.Visibility = Visibility.Hidden;
            BarelL.Visibility = Visibility.Hidden;
            Ham.Visibility = Visibility.Hidden;
            Scot.Visibility = Visibility.Hidden;
        }

        private void Hamer_Click(object sender, RoutedEventArgs e)
        {
            Scot.Visibility = Visibility.Visible;
            Push.Visibility = Visibility.Hidden;
            FrenchB.Visibility = Visibility.Hidden;
            BarelL.Visibility = Visibility.Hidden;
            Ham.Visibility = Visibility.Hidden;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new ExercrisesPage());
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            Push.Visibility = Visibility.Hidden;
            FrenchB.Visibility = Visibility.Hidden;
            BarelL.Visibility = Visibility.Hidden;
            Ham.Visibility = Visibility.Hidden;
            Scot.Visibility = Visibility.Hidden;
        }
    }
}
