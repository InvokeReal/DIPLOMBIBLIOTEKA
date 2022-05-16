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
using System.Windows.Shapes;

namespace Библиотека.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для История_заказов_добавить.xaml
    /// </summary>
    public partial class История_заказов_добавить : Window
    {
        DB.DB db = new DB.DB();
        public История_заказов_добавить()
        {
            InitializeComponent();
            db.Книги.Load();
        }

        private void DobavIstZak_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.История_заказов p = new DB.История_заказов();
                p.Количество = Convert.ToInt32(Количество.Text);
                p.Адрес_доставки = Адрес_доставки.Text;
                p.ФИО_получателя = ФИО_получателя.Text;
                p.Статус = Статус.Text;
                p.Цена = Convert.ToInt32(Цена.Text);
                p.Название_книги = Название_книги.Text;
                db.История_заказов.Add(p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitIstZak_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
