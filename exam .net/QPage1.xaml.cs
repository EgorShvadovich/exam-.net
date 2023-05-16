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
    /// Логика взаимодействия для QPage1.xaml
    /// </summary>
    public partial class QPage1 : Page
    {
        public int correctAnswer = 0;
        public QPage1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButonAnswer1.IsChecked == true) correctAnswer++;

            
            if (radioButonAnswer5.IsChecked == true) correctAnswer++;
            
            
            if (radioButonAnswer9.IsChecked == true) correctAnswer++;
           
            if (radioButonAnswer11.IsChecked == true) correctAnswer++;
            
            if (radioButonAnswer13.IsChecked == true) correctAnswer++;
            
            NavigationService.Navigate(new QPage2(correctAnswer));       
        }
    }
}
