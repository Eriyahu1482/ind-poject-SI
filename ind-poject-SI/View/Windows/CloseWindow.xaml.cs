using System.Windows;

namespace ind_poject_SI.View.Windows
{
    public partial class CloseWindow : Window
    {
        public CloseWindow()
        {
            InitializeComponent();
        }

        private void NO_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void YES_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
