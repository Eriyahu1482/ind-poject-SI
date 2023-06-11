using ind_poject_SI.Core;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.ExercisesPages
{
    public partial class LegsPage : Page
    {
        public LegsPage()
        {
            InitializeComponent();
        }

        private void BenchH_Click(object sender, RoutedEventArgs e)
        {
            squats.Visibility = Visibility.Visible;
            lunges.Visibility = Visibility.Hidden;
            LegP.Visibility = Visibility.Hidden;
            Deadlift.Visibility = Visibility.Hidden;
            hyperextension.Visibility = Visibility.Hidden;
        }

        private void BenchSl_Click(object sender, RoutedEventArgs e)
        {
            lunges.Visibility = Visibility.Visible;
            squats.Visibility = Visibility.Hidden;
            LegP.Visibility = Visibility.Hidden;
            Deadlift.Visibility = Visibility.Hidden;
            hyperextension.Visibility = Visibility.Hidden;
        }

        private void BenchD_Click(object sender, RoutedEventArgs e)
        {
            LegP.Visibility = Visibility.Visible;
            squats.Visibility = Visibility.Hidden;
            lunges.Visibility = Visibility.Hidden;
            Deadlift.Visibility = Visibility.Hidden;
            hyperextension.Visibility = Visibility.Hidden;
        }

        private void Push_ups_Click(object sender, RoutedEventArgs e)
        {
            Deadlift.Visibility = Visibility.Visible;
            LegP.Visibility = Visibility.Hidden;
            squats.Visibility = Visibility.Hidden;
            lunges.Visibility = Visibility.Hidden;
            hyperextension.Visibility = Visibility.Hidden;
        }

        private void Hamer_Click(object sender, RoutedEventArgs e)
        {
            hyperextension.Visibility = Visibility.Visible;
            Deadlift.Visibility = Visibility.Hidden;
            LegP.Visibility = Visibility.Hidden;
            squats.Visibility = Visibility.Hidden;
            lunges.Visibility = Visibility.Hidden;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new ExercrisesPage());
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            Deadlift.Visibility = Visibility.Hidden;
            LegP.Visibility = Visibility.Hidden;
            squats.Visibility = Visibility.Hidden;
            lunges.Visibility = Visibility.Hidden;
            hyperextension.Visibility = Visibility.Hidden;
        }
    }
}
