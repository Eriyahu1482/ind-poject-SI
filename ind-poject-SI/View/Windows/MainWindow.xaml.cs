using ind_poject_SI.Core;
using ind_poject_SI.View.Pages;
using System.Windows;

namespace ind_poject_SI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Core1.MyCore = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }
    }
}
