using ind_poject_SI.Core;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.ExercisesPages
{
    public partial class KegelPage : Page
    {
        public KegelPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new ExercrisesPage());
        }

        private void Kega_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            wt.Visibility = System.Windows.Visibility.Visible;
        }

        private void Hide_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            wt.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
