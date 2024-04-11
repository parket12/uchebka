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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PohoronnoeBuro
{
    /// <summary>
    /// Логика взаимодействия для PageEmployyes.xaml
    /// </summary>
    public partial class PageEmployyes : Page
    {
        private uchEntities db = new uchEntities();
        public PageEmployyes()
        {

            InitializeComponent();
            EmployDgr.ItemsSource = db.Employees.ToList();
            RoleCBx.ItemsSource = db.Rolb.ToList();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            var sur = new PohoronnoeBuro.Employees();

            sur.Surname = TextTBXSur.Text;
            sur.FirstName = TextTBxFNam.Text;
            sur.login = TextTBxLog.Text;
            sur.password = TextTBx.Text;
            sur.Rolb_ID = (RoleCBx.SelectedItem as Rolb).ID_Rolb;

            db.Employees.Add(sur);
            db.SaveChanges();
            EmployDgr.ItemsSource = db.Employees.ToList();
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                var selected = EmployDgr.SelectedItem as Employees;
                selected.Surname = TextTBXSur.Text;
                selected.FirstName = TextTBxFNam.Text;
                selected.login = TextTBxLog.Text;
                selected.password = TextTBx.Text;
                selected.Rolb_ID = (RoleCBx.SelectedItem as Rolb).ID_Rolb;
                db.SaveChanges();
                EmployDgr.ItemsSource = db.Employees.ToList();
            }
        }

        

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                db.Employees.Remove(EmployDgr.SelectedItem as Employees);
                db.SaveChanges();
                EmployDgr.ItemsSource = db.Employees.ToList();
            }
        }

        private void RoleDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                var selected = EmployDgr.SelectedItem as Employees;
                TextTBXSur.Text = selected.Surname;
                TextTBxFNam.Text = selected.FirstName;
                TextTBxLog.Text = selected.login;
                TextTBx.Text = selected.password;
                RoleCBx.SelectedItem = selected.Rolb;
            }
        }

        private void EmpBut_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Emp_Click(object sender, RoutedEventArgs e)
        {
            AdminPage window = new AdminPage();
            window.Show();
            
        }
    }
}
