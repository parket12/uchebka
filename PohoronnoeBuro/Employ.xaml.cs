using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PohoronnoeBuro
{
    public partial class Employ : Window
    {

        private uchEntities db = new uchEntities();

        public Employ()
        {
            InitializeComponent();
            EmployDgr.ItemsSource = db.Employees.ToList();
            RoleCBx.ItemsSource = db.Rolb.ToList();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            var sur = new PohoronnoeBuro.Employees();

            if (string.IsNullOrWhiteSpace(TextTBXSur.Text))
            {
                MessageBox.Show("Поле 'Surname' не должно быть пустым.");
                return;
            }
            
            if (!Regex.IsMatch(TextTBXSur.Text, "^[а-яА-Я]*$"))
            {
                MessageBox.Show("Поле 'Surname' должно содержать только буквы.");
                return;
            }
            sur.Surname = TextTBXSur.Text;

         
            if (string.IsNullOrWhiteSpace(TextTBxFNam.Text))
            {
                MessageBox.Show("Поле 'FirstName' не должно быть пустым.");
                return;
            }
            if (!Regex.IsMatch(TextTBxFNam.Text, "^[а-яА-Я]*$"))
            {
                MessageBox.Show("Поле 'FirstName' должно содержать только буквы.");
                return;
            }
            sur.FirstName = TextTBxFNam.Text;

            if (string.IsNullOrWhiteSpace(TextTBxLog.Text))
            {
                MessageBox.Show("Поле 'Login' не должно быть пустым.");
                return;
            }
            sur.login = TextTBxLog.Text;

            if (string.IsNullOrWhiteSpace(TextTBx.Password))
            {
                MessageBox.Show("Поле 'Password' не должно быть пустым.");
                return;
            }
            Employees existingUser = db.Employees.FirstOrDefault(u => u.login == TextTBxLog.Text && u.ID_Employees != sur.ID_Employees);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            sur.password = TextTBx.Password;

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
                if (string.IsNullOrWhiteSpace(TextTBXSur.Text))
                {
                    MessageBox.Show("Поле 'Surname' не должно быть пустым.");
                    return;
                }

                if (!Regex.IsMatch(TextTBXSur.Text, "^[а-яА-Я]*$"))
                {
                    MessageBox.Show("Поле 'Surname' должно содержать только буквы.");
                    return;
                }
                selected.Surname = TextTBXSur.Text;


                if (string.IsNullOrWhiteSpace(TextTBxFNam.Text))
                {
                    MessageBox.Show("Поле 'FirstName' не должно быть пустым.");
                    return;
                }
                if (!Regex.IsMatch(TextTBxFNam.Text, "^[а-яА-Я]*$"))
                {
                    MessageBox.Show("Поле 'FirstName' должно содержать только буквы.");
                    return;
                }
                selected.FirstName = TextTBxFNam.Text;

                if (string.IsNullOrWhiteSpace(TextTBxLog.Text))
                {
                    MessageBox.Show("Поле 'Login' не должно быть пустым.");
                    return;
                }
                selected.login = TextTBxLog.Text;

                if (string.IsNullOrWhiteSpace(TextTBx.Password))
                {
                    MessageBox.Show("Поле 'Password' не должно быть пустым.");
                    return;
                }
                Employees existingUser = db.Employees.FirstOrDefault(u => u.login == TextTBxLog.Text && u.ID_Employees != selected.ID_Employees);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка валидации", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
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
                TextTBx.Password = selected.password;
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
            Close();
        }
    }
}
