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
    /// Логика взаимодействия для Книги_добавить.xaml
    /// </summary>
    public partial class Книги_добавить : Window
    {
        DB.DB db = new DB.DB();
        public Книги_добавить()
        {
            InitializeComponent();
        }


        private void ExitKnig_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DobavKnig_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Книги p1 = new DB.Книги();
                p1.Название = Название.Text;
                p1.Цена = Convert.ToDecimal(Цена.Text);
                p1.Жанр = Жанр.Text;
                p1.Издатель = Издатель.Text;
                p1.Дата_издания = Дата_издания.Text;
                p1.В_наличии = Convert.ToInt32(В_наличии.Text);
                p1.Описание = Описание.Text;
                p1.Фото = Фото.Text;
                p1.Поставщик_книг = Convert.ToInt32(Поставщик_книг.Text);
                db.Книги.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
