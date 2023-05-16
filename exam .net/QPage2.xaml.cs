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
    /// Логика взаимодействия для QPage2.xaml
    /// </summary>
    public partial class QPage2 : Page
    {
        int correctAnswer;
        public QPage2(int x)
        {
            InitializeComponent();
            correctAnswer = x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (radioButonAnswer3.IsChecked == true) correctAnswer++;
           
            if (radioButonAnswer6.IsChecked == true) correctAnswer++;
           
            if (radioButonAnswer9.IsChecked == true) correctAnswer++;
            if (radioButonAnswer10.IsChecked == true) correctAnswer++;
            
            if (radioButonAnswer14.IsChecked == true) correctAnswer++;
            
            NavigationService.Navigate(new QPage3(correctAnswer));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             
            NavigationService.GoBack();
        }
    }
}
