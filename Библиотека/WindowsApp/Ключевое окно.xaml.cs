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
using System.Windows.Shapes;

namespace Библиотека.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для Ключевое_окно.xaml
    /// </summary>
    public partial class Ключевое_окно : Window
    {
        public Ключевое_окно()
        {
            InitializeComponent();
        }

        private void Knigi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frame.Книги_подробно());
        }

        private void Sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frame.Сотрудники());
        }

        private void Postavshiki_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frame.Поставщики());
        }

        private void Chitateli_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frame.Читатели());
        }

        private void Istorya_Zakazov_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frame.История_заказов());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
