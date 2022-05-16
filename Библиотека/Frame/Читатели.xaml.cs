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
using Библиотека.DB;

namespace Библиотека.Frame
{
    /// <summary>
    /// Логика взаимодействия для Читатели.xaml
    /// </summary>
    public partial class Читатели : Page
    {
        DB.DB db = new DB.DB();
        public Читатели()
        {
            InitializeComponent();
            db.Читатель.Load();
            dch.ItemsSource = db.Читатель.Local.ToBindingList();
        }

        private void SearchCH_TextChanged(object sender, TextChangedEventArgs e)
        {
            dch.ItemsSource = db.Читатель.Local.Where(x => x.ФИО.ToLower().Contains(searchCH.Text.ToLower()) || x.ФИО.ToLower().Contains(searchCH.Text.ToLower()));
        }

        private void ChitPT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ChitPT.SelectedIndex)
            {
                case 0:
                    dch.ItemsSource = db.Читатель.Local;
                    break;
                case 1:
                    dch.ItemsSource = db.Читатель.Local.OrderBy(x => x.ФИО);
                    break;
                case 2:
                    dch.ItemsSource = db.Читатель.Local.OrderByDescending(x => x.ФИО);
                    break;
            }
        }

       

        private void ChitatDob_Click(object sender, RoutedEventArgs e)
        {
            WindowsApp.Читатель_добавить window = new WindowsApp.Читатель_добавить();
            window.Show();
        }

        private void ChitatUdal_Click(object sender, RoutedEventArgs e)
        {
            if (dch.SelectedItem != null)
            {
                WindowsApp.Читатель_удалить window = new WindowsApp.Читатель_удалить(((Читатель)dch.SelectedItem).ID_читателя);
                window.Show();
            }
            else
            {
                MessageBox.Show("Вы не выделили поле");
            }
        }

        private void Dch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            dch.ItemsSource = db.Читатель.Local.ToBindingList();
        }
    }
}
