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
    /// Логика взаимодействия для plott.xaml
    /// </summary>
    public partial class plott : Window
    {
        private uchEntities db = new uchEntities();
        public plott()
        {
            InitializeComponent();
            RoleDgr.ItemsSource = db.Plot.ToList();

        }
        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            var role = new PohoronnoeBuro.Plot();
            role.NamePlot = TextTBx.Text;
            db.Plot.Add(role);
            if (string.IsNullOrWhiteSpace(TextTBx.Text))
            {
                MessageBox.Show("Поле 'Name Plot' не должно быть пустым.");
                return;
            }
            db.SaveChanges();
            RoleDgr.ItemsSource = db.Plot.ToList();
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                var selected = RoleDgr.SelectedItem as Plot;
                selected.NamePlot = TextTBx.Text;
                if (string.IsNullOrWhiteSpace(TextTBx.Text))
                {
                    MessageBox.Show("Поле 'Name Plot' не должно быть пустым.");
                    return;
                }
                db.SaveChanges();
                RoleDgr.ItemsSource = db.Plot.ToList();
            }
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                db.Plot.Remove(RoleDgr.SelectedItem as Plot);
                db.SaveChanges();
                RoleDgr.ItemsSource = db.Plot.ToList();
            }
        }

        private void RoleDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoleDgr.SelectedItem != null)
            {
                var selected = RoleDgr.SelectedItem as Plot;

                TextTBx.Text = selected.NamePlot;
            }
        }




        private void ToInsureWin_Click(object sender, RoutedEventArgs e)
        {
            Insure window = new Insure();
            window.Show();
            Close();
        }

        private void ToPlotWin_Click(object sender, RoutedEventArgs e)
        {
            KassaPage window = new KassaPage();
            window.Show();
            Close();
        }

        private void ToPaymentMetWin_Click(object sender, RoutedEventArgs e)
        {
            Payment window = new Payment();
            window.Show();
            Close();
        }

        private void ToStockMetWin_Click(object sender, RoutedEventArgs e)
        {
            Stocccc window = new Stocccc();
            window.Show();
            Close();
        }

        private void ToCategoriiWin_Click(object sender, RoutedEventArgs e)
        {
            KassaPage window = new KassaPage();
            window.Show();
            Close();
        }

        private void TextTBx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ToInfoWin_Click(object sender, RoutedEventArgs e)
        {
            Infoooo window = new Infoooo();
            window.Show();
            Close();
        }
    }
}
