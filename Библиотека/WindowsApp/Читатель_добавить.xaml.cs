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
    /// Логика взаимодействия для Читатель_добавить.xaml
    /// </summary>
    public partial class Читатель_добавить : Window
    {
        DB.DB db = new DB.DB();
        public Читатель_добавить()
        {
            InitializeComponent();
        }

        private void ExitChit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Читатель p4 = new DB.Читатель();
                p4.ФИО = ФИО.Text;
                p4.Телефон = Convert.ToInt32(Телефон.Text);
                p4.Дата_взятия = Convert.ToDateTime(Дата_взятия.Text);
                p4.Дата_возврата = Convert.ToDateTime(Дата_возврата.Text);
                p4.Одолженные_книги = Convert.ToInt32(Одолженные_книги.Text);
                p4.Состояние = Состояние.Text;
                p4.Адрес = Адрес.Text;
                p4.Паспортные_данные = Convert.ToInt32(Паспортные_данные.Text);
                db.Читатель.Add(p4);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DobavChit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
