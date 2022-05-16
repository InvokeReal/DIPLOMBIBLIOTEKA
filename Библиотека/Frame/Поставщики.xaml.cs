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
    /// Логика взаимодействия для Поставщики.xaml
    /// </summary>
    public partial class Поставщики : Page
    {
        DB.DB db = new DB.DB();
        public Поставщики()
        {
            
            InitializeComponent();
            db.Поставщики.Load();
            dp.ItemsSource = db.Поставщики.Local.ToBindingList();
            
        }

        private void SortPT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dp.ItemsSource = db.Поставщики.Local.OrderBy(a => a.Страна).Where(x => x.Страна.Equals(sortPT.Text));
        
        }
    

        private void PostavDob_Click(object sender, RoutedEventArgs e)
        {
            WindowsApp.Поставщики_добавить window = new WindowsApp.Поставщики_добавить();
            window.Show();
        }

        private void PostavUdal_Click(object sender, RoutedEventArgs e)
        {
            if (dp.SelectedItem != null)
            {
                WindowsApp.Поставщики_удалить window = new WindowsApp.Поставщики_удалить(((DB.Поставщики)dp.SelectedItem).ID_поставщика);
                window.Show();
            }
            else
            {
                MessageBox.Show("Вы не выделили поле");
            }
        }

        private void SearchPT_TextChanged(object sender, TextChangedEventArgs e)
        {
            dp.ItemsSource = db.Поставщики.Local.Where(x => x.Наименование.ToLower().Contains(searchPT.Text.ToLower()) || x.Наименование.ToLower().Contains(searchPT.Text.ToLower()));
        }

        private void Dp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            dp.ItemsSource = db.Поставщики.Local.ToBindingList();
        }
    }
}
