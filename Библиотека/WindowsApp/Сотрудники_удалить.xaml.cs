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
    /// Логика взаимодействия для Сотрудники_удалить.xaml
    /// </summary>
    public partial class Сотрудники_удалить : Window
    {
        DB.DB db = new DB.DB();
        int idGlobal3;
        public Сотрудники_удалить(int id)
        {
            InitializeComponent();
            db.Сотрудники.Load();
            idGlobal3 = id;
        }

        private void NeUdalSot_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UdalSot_Click(object sender, RoutedEventArgs e)
        {
            Сотрудники op3 = db.Сотрудники.Where(x => x.ID_сотрудника == idGlobal3).FirstOrDefault();
            db.Сотрудники.Remove(op3);
            db.SaveChanges();
            this.Close();
        }
    }
}
