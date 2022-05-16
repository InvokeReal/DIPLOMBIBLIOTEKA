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
using Word = Microsoft.Office.Interop.Word;

namespace Библиотека.Frame
{
    /// <summary>
    /// Логика взаимодействия для История_заказов.xaml
    /// </summary>
    public partial class История_заказов : Page
    {
        DB.DB db = new DB.DB();
        public История_заказов()
        {
            InitializeComponent();
            db.История_заказов.Load();
            diz.ItemsSource = db.История_заказов.Local.ToBindingList();

        }

        private void FiltIZ_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (FiltIZ.SelectedIndex)
            {
                case 0:
                    diz.ItemsSource = db.История_заказов.Local;
                    break;
                case 1:
                    diz.ItemsSource = db.История_заказов.Local.OrderBy(x => x.ФИО_получателя);
                    break;
                case 2:
                    diz.ItemsSource = db.История_заказов.Local.OrderByDescending(x => x.ФИО_получателя);
                    break;
            }
        }

        private void SearchIZ_TextChanged(object sender, TextChangedEventArgs e)
        {
            diz.ItemsSource = db.История_заказов.Local.Where(x => x.ФИО_получателя.ToLower().Contains(searchIZ.Text.ToLower()) || x.ФИО_получателя.ToLower().Contains(searchIZ.Text.ToLower()));
        }


        private void IstZakDob_Click(object sender, RoutedEventArgs e)
        {
            WindowsApp.История_заказов_добавить window = new WindowsApp.История_заказов_добавить();
            window.Show();
        }

        private void IstZakUdal_Click(object sender, RoutedEventArgs e)
        {
            if (diz.SelectedItem != null)
            {
                WindowsApp.История_заказов_удалить window = new WindowsApp.История_заказов_удалить(((DB.История_заказов)diz.SelectedItem).ID_заказа);
                window.Show();
            }
            else
            {
                MessageBox.Show("Вы не выделили поле");
            }
        }

        private void BtnExportToWord_Click(object sender, RoutedEventArgs e)
        {

                if (diz.SelectedItem !=null)
                {
                    System.Diagnostics.Process.Start(@"C:\Users\Марина\source\repos\Библиотека\Библиотека\WindowsApp\check.docx");
                }
                else
                {
                    System.Diagnostics.Process.Start(@"C:\Users\Марина\source\repos\Библиотека\Библиотека\WindowsApp\check.docx1");
                }
            
        }

        private void Diz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            diz.ItemsSource = db.История_заказов.Local.ToBindingList();
        }
    }
}
