using System;
using Библиотека.DB;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Библиотека.Frame
{
    /// <summary>
    /// Логика взаимодействия для Книги_подробно.xaml
    /// </summary>
    public partial class Книги_подробно : Page
    {
        DB.DB db = new DB.DB();
        public Книги_подробно()
        {
            InitializeComponent();
            db.Книги.Load();
            dk.ItemsSource = db.Книги.Local.ToBindingList();
        }

        private void KnigiRedak_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            dk.ItemsSource = db.Книги.Local.ToBindingList();
        }

        private void KnigiDob_Click(object sender, RoutedEventArgs e)
        {
            WindowsApp.Книги_добавить window = new WindowsApp.Книги_добавить();
            window.Show();
        }

        private void KnigiUdal_Click(object sender, RoutedEventArgs e)
        {
            if (dk.SelectedItem != null)
            {
                WindowsApp.Книги_удалить window = new WindowsApp.Книги_удалить(((DB.Книги)dk.SelectedItem).ID_книги);
                window.Show();
            }
            else
            {
                MessageBox.Show("Вы не выделили поле");
            }
        }

        private void SearchKNP_TextChanged(object sender, TextChangedEventArgs e)
        {
            dk.ItemsSource = db.Книги.Local.Where(x => x.Название.ToLower().Contains(searchKNP.Text.ToLower()) || x.Название.ToLower().Contains(searchKNP.Text.ToLower()));
        }

        private void FiltKNP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (filtKNP.SelectedIndex)
            {
                case 0:
                    dk.ItemsSource = db.Книги.Local;
                    break;
                case 1:
                    dk.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 1);
                    break;
                case 2:
                    dk.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 2);
                    break;
                case 3:
                    dk.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 3);
                    break;
                case 4:
                    dk.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 4);
                    break;
                default:
                    break;
            }
        }

        private void Dk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            dk.ItemsSource = db.Книги.Local.ToBindingList();
        }
    }
}
