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
    /// Логика взаимодействия для Аутентификация.xaml
    /// </summary>
    public partial class Аутентификация : Window
    {
        DB.DB db = new DB.DB();
        public Аутентификация()
        {
            InitializeComponent();
            db.Сотрудники.Load();
            
        }

        private void Voiti_Click(object sender, RoutedEventArgs e)
        {
            Auth(ViborLog.Text, Spispar.Password);
        }
        public bool Auth(string Vibor, string Spispar)
        {
            if (string.IsNullOrEmpty(Vibor) || string.IsNullOrEmpty(Spispar))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }
            using (var db = new DB.DB())
            {
                var user = db.Сотрудники.AsNoTracking().FirstOrDefault(u => u.login == Vibor && u.password == Spispar);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return false;
                }
                Ключевое_окно window = new Ключевое_окно();
                window.Show();
                return true;
            }
        }
    }
}
