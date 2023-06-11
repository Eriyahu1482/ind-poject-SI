using ind_poject_SI.Core;
using ind_poject_SI.Model;
using ind_poject_SI.View.Windows;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ind_poject_SI.View.Pages
{
    public partial class RegistrationPage : Page
    {
        private ModelContext _db = null;
        private User _user = new User();
        public RegistrationPage()
        {
            InitializeComponent();

            _db = new ModelContext();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Core1.MyCore?.Navigate(new LoginPage());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTxt.Text) ||  string.IsNullOrEmpty(PassTxt.Password))
            {
                MessageBox.Show("Ошибка ввода данных", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    _user.Login = LoginTxt.Text;
                    _user.Password = PassTxt.Password;
                    _user.RoleID = 2;

                    MessageBox.Show("Аккаунт создан", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error );

                    _db?.Users.Add( _user );
                    _db?.SaveChanges();

                    Core1.MyCore?.Navigate(new LoginPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            new CloseWindow().ShowDialog();
        }
    }
}
