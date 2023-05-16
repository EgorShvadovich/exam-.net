using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace exam_.net
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Focus();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String passwordHash = Hash(PasswordTextBox.Password);

            var authUser = App.DataContext.NpUsers.FirstOrDefault(user => user.Login == LoginTextBox.Text && user.Password == passwordHash);
            if (authUser is null)
            {
                MessageBox.Show("вход отклонен");
            }
            else
            {
                this.Hide();
                new LoginWindow().ShowDialog();
                PasswordTextBox.Password = "";
                this.Show();
            }
        }

        private string Hash(string str)
        {
            using MD5 md5 = MD5.Create();
            return Convert.ToHexString(md5.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }
    }
}
