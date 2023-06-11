using ind_poject_SI.Core;
using ind_poject_SI.View.Pages.Main.Menu;
using ind_poject_SI.View.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Exercises_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Core1.MyCore?.Navigate(new ExercrisesPage());
        }

        private void Timer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Core1.MyCore?.Navigate(new TimerPage());
        }

        private void Lid_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Core1.MyCore?.Navigate(new LiderPage());
        }

        private void Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new CloseWindow().ShowDialog();
        }
    }
}
