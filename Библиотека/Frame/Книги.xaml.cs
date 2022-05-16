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
    /// Логика взаимодействия для Книги.xaml
    /// </summary>
    public partial class Книги : Page
    {
        DB.DB db = new DB.DB();
        public Книги()
        {

            InitializeComponent();
            db.Книги.Load();
            lll.ItemsSource = db.Книги.Local;
        }

        private void SearchKN_TextChanged(object sender, TextChangedEventArgs e)
        {
            lll.ItemsSource = db.Книги.Local.Where(x => x.Название.ToLower().Contains(searchKN.Text.ToLower()) || x.Название.ToLower().Contains(searchKN.Text.ToLower()));
        }

        private void FiltKN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (filtKN.SelectedIndex)
            {

                case 0:
                    lll.ItemsSource = db.Книги.Local;
                    break;
                case 1:
                    lll.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 1);
                    break;
                case 2:
                    lll.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 2);
                    break;
                case 3:
                    lll.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 3);
                    break;
                case 4:
                    lll.ItemsSource = db.Книги.Local.Where(x => x.ID_книги == 4);
                    break;
                default:
                    break;
            }
        }
    }
}
