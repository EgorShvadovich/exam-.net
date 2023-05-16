using MySqlConnector;
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

namespace exam_.net
{
    /// <summary>
    /// Логика взаимодействия для Finish.xaml
    /// </summary>
    public partial class Finish : Page
    {
        int correctAnswer;


        // Создание строки подключения
        string connectionString = "Server=aws.connect.psdb.cloud;Database=database1;uid=10311ca41fkdyet6n2lg;password=pscale_pw_XIdY1AUM0JH4gYXAX5hreh7aPGRpsvyoDYM3UJYEEJA";

        public Finish(int x)
        {
            InitializeComponent();
            correctAnswer = x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            resultAnswer.Content = "Ваш результат: " + correctAnswer + "/15";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO NPUsers (Id, Name, Email, ConfirmCode, Login, Password, UserRates ) VALUES (@Id, @Name, @Email, @ConfirmCode, @Login, @Password, @UserRates)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", "1");
                    command.Parameters.AddWithValue("@UserRates", correctAnswer);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно загружены в таблицу.");
            }
        }
    }
}

