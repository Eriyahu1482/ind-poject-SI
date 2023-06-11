using ind_poject_SI.Core;
using ind_poject_SI.View.Pages.ExercisesPages;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages
{
        public partial class ExercrisesPage : Page
        {
            public ExercrisesPage()
            {
                InitializeComponent();
            }

            private void breast_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new BreastPage());
            }


            private void Arms_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new ArmsPage());
            }

            private void shoulders_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new ShourdersPage());
            }

            private void Legs_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new LegsPage());
            }

            private void XD_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new KegelPage());
            }

            private void Back_Click(object sender, RoutedEventArgs e)
            {
                Core1.MyCore.Navigate(new MainPage());
            }
        }
    }

