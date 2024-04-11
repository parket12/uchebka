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

namespace PohoronnoeBuro
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        private uchEntities db = new uchEntities();
        public AdminPage()
        {
            InitializeComponent();
            RoleDgr.ItemsSource = db.Rolb.ToList();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            var role = new PohoronnoeBuro.Rolb();
            role.RoleName = TextTBx.Text;
            db.Rolb.Add(role);
            if (string.IsNullOrWhiteSpace(TextTBx.Text))
            {
                MessageBox.Show("Поле 'Role Name' не должно быть пустым.");
                return;
            }
            db.SaveChanges();
            RoleDgr.ItemsSource = db.Rolb.ToList();
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                var selected = RoleDgr.SelectedItem as Rolb;
                selected.RoleName = TextTBx.Text;
                if (string.IsNullOrWhiteSpace(TextTBx.Text))
                {
                    MessageBox.Show("Поле 'Role Name' не должно быть пустым.");
                    return;
                }
                db.SaveChanges();
                RoleDgr.ItemsSource = db.Rolb.ToList();
            }
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                db.Rolb.Remove(RoleDgr.SelectedItem as Rolb);
                db.SaveChanges();
                RoleDgr.ItemsSource= db.Rolb.ToList();  
            }
        }

        private void RoleDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                var selected = RoleDgr.SelectedItem as Rolb;

                TextTBx.Text = selected.RoleName;
            }
        }
       
        private void EmpBut_Click(object sender, RoutedEventArgs e)
        {
            Employ window = new Employ();
            window.Show();
            Close();
        }

        private void EmpBut_Копировать_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
