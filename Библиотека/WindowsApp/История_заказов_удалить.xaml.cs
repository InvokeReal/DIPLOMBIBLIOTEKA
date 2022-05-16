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
using Библиотека.DB;

namespace Библиотека.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для История_заказов_удалить.xaml
    /// </summary>
    public partial class История_заказов_удалить : Window
    {
        DB.DB db = new DB.DB();
        int idGlobal;
        public История_заказов_удалить(int id)
        {
            InitializeComponent();
            db.История_заказов.Load();
            idGlobal = id;
        }

        private void UdalIstZak_Click(object sender, RoutedEventArgs e)
        {
            История_заказов op = db.История_заказов.Where(x => x.ID_заказа == idGlobal).FirstOrDefault();
            db.История_заказов.Remove(op);
            db.SaveChanges();
            this.Close();
        }

        private void NeUdalIstZak_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
