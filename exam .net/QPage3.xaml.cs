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
    /// Логика взаимодействия для QPage3.xaml
    /// </summary>
    public partial class QPage3 : Page
    {
        int correctAnswer;
        public QPage3(int x)
        {
            InitializeComponent();
            correctAnswer = x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButonAnswer2.IsChecked == true) correctAnswer++;
          
            if (radioButonAnswer5.IsChecked == true) correctAnswer++;
           
            if (radioButonAnswer7.IsChecked == true) correctAnswer++;

            if (radioButonAnswer11.IsChecked == true) correctAnswer++;

            if (radioButonAnswer15.IsChecked == true) correctAnswer++;
            NavigationService.Navigate(new Finish(correctAnswer));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
