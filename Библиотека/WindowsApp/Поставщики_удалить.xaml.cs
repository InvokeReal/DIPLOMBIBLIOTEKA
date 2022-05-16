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
    /// Логика взаимодействия для Поставщики_удалить.xaml
    /// </summary>
    public partial class Поставщики_удалить : Window
    {
        DB.DB db = new DB.DB();
        int idGlobal2;
        public Поставщики_удалить(int id)
        {
            InitializeComponent();
            db.Книги.Load();
            idGlobal2 = id;
        }

        private void UdalPostav_Click(object sender, RoutedEventArgs e)
        {
            Поставщики op2 = db.Поставщики.Where(x => x.ID_поставщика == idGlobal2).FirstOrDefault();
            db.Поставщики.Remove(op2);
            db.SaveChanges();
            this.Close();
        }

        private void NeUdalPostav_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
