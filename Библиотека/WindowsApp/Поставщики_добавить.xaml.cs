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
    /// Логика взаимодействия для Поставщики_добавить.xaml
    /// </summary>
    public partial class Поставщики_добавить : Window
    {
        DB.DB db = new DB.DB();
        public Поставщики_добавить()
        {
            InitializeComponent();
        }

        private void DobavPost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Поставщики p2 = new DB.Поставщики();
                p2.Наименование = Наименование.Text;
                p2.Страна = Страна.Text;
                p2.ИНН = Convert.ToInt32(ИНН.Text);
                db.Поставщики.Add(p2);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitPost_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
