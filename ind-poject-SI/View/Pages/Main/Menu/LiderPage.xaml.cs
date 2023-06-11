using ind_poject_SI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ind_poject_SI.View.Pages.Main.Menu
{
    /// <summary>
    /// Логика взаимодействия для LiderPage.xaml
    /// </summary>
    public partial class LiderPage : Page
    {
        public LiderPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore?.Navigate(new MainPage());
        }
    }
}
