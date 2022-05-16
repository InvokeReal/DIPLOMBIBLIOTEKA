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
    /// Логика взаимодействия для Книги_удалить.xaml
    /// </summary>
    public partial class Книги_удалить : Window
    {
        DB.DB db = new DB.DB();
        int idGlobal1;
        public Книги_удалить(int id)
        {
            InitializeComponent();
            db.Книги.Load();
            idGlobal1 = id;
        }

        private void UdalKnigi_Click(object sender, RoutedEventArgs e)
        {
            Книги op1 = db.Книги.Where(x => x.ID_книги == idGlobal1).FirstOrDefault();
            db.Книги.Remove(op1);
            db.SaveChanges();
            this.Close();
        }

        private void NeUdalKnigi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
