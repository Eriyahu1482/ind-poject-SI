using ind_poject_SI.Core;
using ind_poject_SI.Model.LiderBord;
using System.Windows;
using System.Windows.Controls;

namespace ind_poject_SI.View.Pages.Main.Menu
{
    LiderContext context;
    Statistics NewStatistics = new Statistics();
    Statistics selectedStatiscs = new Statistics();
    public partial class LiderPage : Page
    {
        public LiderPage(LiderContext context)
        {
            InitializeComponent();
            this.context = context;
            InitializeComponent();
            GetStatistics();
            NewStatisticsGrid.DataContext = NewStatistics;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore?.Navigate(new MainPage());
        }
    }
}
