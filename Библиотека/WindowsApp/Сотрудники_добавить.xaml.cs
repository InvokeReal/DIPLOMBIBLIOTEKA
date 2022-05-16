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
    /// Логика взаимодействия для Сотрудники_добавить.xaml
    /// </summary>
    public partial class Сотрудники_добавить : Window
    {
        DB.DB db = new DB.DB();
        public Сотрудники_добавить()
        {
            InitializeComponent();
        }

        private void DobavSotr_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Сотрудники p3 = new DB.Сотрудники();
                p3.ФИО = ФИО.Text;
                p3.Дата_рождения = Convert.ToDateTime(Дата_рождения.Text);
                p3.Телефон = Convert.ToInt32(Телефон.Text);
                p3.ИНН = Convert.ToInt32(ИНН.Text);
                p3.Паспортные_данные = Convert.ToInt32(Паспортные_данные.Text);
                p3.Адрес_проживания = Адрес_проживания.Text;
                p3.Оклад = Convert.ToDecimal(Оклад.Text);
                p3.Должность = Должность.Text;
                p3.login = login.Text;
                p3.password = password.Text;
                db.Сотрудники.Add(p3);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitSotr_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
