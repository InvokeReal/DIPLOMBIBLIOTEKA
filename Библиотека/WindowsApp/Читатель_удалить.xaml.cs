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
    /// Логика взаимодействия для Читатель_удалить.xaml
    /// </summary>
    public partial class Читатель_удалить : Window
    {
        DB.DB db = new DB.DB();
        int idGlobal4;
        public Читатель_удалить(int id)
        {
            InitializeComponent();
            db.Читатель.Load();
            idGlobal4 = id;
        }

        private void UdalChitat_Click(object sender, RoutedEventArgs e)
        {
            Читатель op4 = db.Читатель.Where(x => x.ID_читателя == idGlobal4).FirstOrDefault();
            db.Читатель.Remove(op4);
            db.SaveChanges();
            this.Close();
        }

        private void NeUdalChitat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
