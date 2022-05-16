using System;
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
    /// Логика взаимодействия для Сотрудники.xaml
    /// </summary>
    public partial class Сотрудники : Page
    {
        DB.DB db = new DB.DB();
        public Сотрудники()
        {
            InitializeComponent();
            db.Сотрудники.Load();
            ds.ItemsSource = db.Сотрудники.Local.ToBindingList();
        }

        private void FiltSot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (filtSot.SelectedIndex)
            {
                case 0:
                    ds.ItemsSource = db.Сотрудники.Local;
                    break;
                case 1:
                    ds.ItemsSource = db.Сотрудники.Local.OrderBy(x => x.ФИО);
                    break;
                case 2:
                    ds.ItemsSource = db.Сотрудники.Local.OrderByDescending(x => x.ФИО);
                    break;
            }
        }

        private void SearchSot_TextChanged(object sender, TextChangedEventArgs e)
        {
            ds.ItemsSource = db.Сотрудники.Local.Where(x => x.ФИО.ToLower().Contains(searchSot.Text.ToLower()) || x.ФИО.ToLower().Contains(searchSot.Text.ToLower()));
        }

        private void SotrDob_Click(object sender, RoutedEventArgs e)
        {
            WindowsApp.Сотрудники_добавить window = new WindowsApp.Сотрудники_добавить();
            window.Show();
        }

        private void SotrUdal_Click(object sender, RoutedEventArgs e)
        {
            if (ds.SelectedItem != null)
            {
                WindowsApp.Сотрудники_удалить window = new WindowsApp.Сотрудники_удалить(((DB.Сотрудники)ds.SelectedItem).ID_сотрудника);
                window.Show();
            }
            else
            {
                MessageBox.Show("Вы не выделили поле");
            }
        }

        private void Ds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            ds.ItemsSource = db.Сотрудники.Local.ToBindingList();

        }
    }
}
