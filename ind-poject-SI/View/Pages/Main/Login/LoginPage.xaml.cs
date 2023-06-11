using ind_poject_SI.Core;
using ind_poject_SI.Model;
using ind_poject_SI.View.Windows;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ind_poject_SI.View.Pages
{
    public partial class LoginPage : Page
    {
        private  ModelContext? _db = null;
        public LoginPage()
        {
            InitializeComponent();
            _db = new ModelContext();
        }
        private void Registration_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Core1.MyCore?.Navigate(new RegistrationPage());
        }

        private void Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
                User? userModel = _db?.Users.FirstOrDefault(predicate: x => x.Login == LoginTxt.Text && x.Password == PassTxt.Password);

                if (userModel != null)
                {
                    switch (userModel.Role.RoleID)
                    {
                        case 1:
                            Core1.MyCore?.Navigate(new MainPage());
                            break;
                        case 2:
                            Core1.MyCore?.Navigate(new MainPage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода данных", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        private void Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            new CloseWindow().ShowDialog();
        }
    }
}
