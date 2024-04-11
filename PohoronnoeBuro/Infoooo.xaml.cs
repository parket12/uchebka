using System;
using System.Collections.Generic;
using System.Linq;
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
    /// <summary>
    /// Логика взаимодействия для Infoooo.xaml
    /// </summary>
    public partial class Infoooo : Window
    {

        private uchEntities db = new uchEntities();
        public Infoooo()
        {
            InitializeComponent();
            EmployDgr.ItemsSource = db.Info.ToList();
            CategoryCBx.ItemsSource = db.Stock.ToList();
            InsureCBx.ItemsSource = db.PaymentMethod.ToList();
            PlotCBx.ItemsSource = db.Employees.ToList();
        }

        private void EmployDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                var selected = EmployDgr.SelectedItem as Info;
                NameProdTBx.Text = selected.DateInfo.ToString();
                CategoryCBx.SelectedItem = selected.Stock;
                InsureCBx.SelectedItem = selected.PaymentMethod;
                PlotCBx.SelectedItem = selected.Employees;
            }
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                db.Info.Remove(EmployDgr.SelectedItem as Info);
                db.SaveChanges();
                EmployDgr.ItemsSource = db.Info.ToList();
            }
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {

                var sur = EmployDgr.SelectedItem as Info;

                if (string.IsNullOrWhiteSpace(NameProdTBx.Text))
                {
                    MessageBox.Show("Поле 'Date Info' не должно быть пустым.");
                    return;
                }


                sur.DateInfo = Convert.ToDateTime(NameProdTBx.Text);
                sur.Stock_ID = (CategoryCBx.SelectedItem as Stock).ID_Stock;
                sur.PaymentMethod_ID = (InsureCBx.SelectedItem as PaymentMethod).ID_PaymentMethod;
                sur.Employees_ID = (PlotCBx.SelectedItem as Employees).ID_Employees;
                db.SaveChanges();
                EmployDgr.ItemsSource = db.Info.ToList();
            }
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {


            var sur = new PohoronnoeBuro.Info();

            if (string.IsNullOrWhiteSpace(NameProdTBx.Text))
            {
                MessageBox.Show("Поле 'Date Info' не должно быть пустым.");
                return;
            }


            sur.DateInfo = Convert.ToDateTime(NameProdTBx.Text);
            sur.Stock_ID = (CategoryCBx.SelectedItem as Stock).ID_Stock;
            sur.PaymentMethod_ID = (InsureCBx.SelectedItem as PaymentMethod).ID_PaymentMethod;
            sur.Employees_ID = (PlotCBx.SelectedItem as Employees).ID_Employees;



            db.Info.Add(sur);
            db.SaveChanges();
            EmployDgr.ItemsSource = db.Info.ToList();
        }





        private void ToInsureWin_Click(object sender, RoutedEventArgs e)
        {
            Insure window = new Insure();
            window.Show();
            Close();
        }

        private void ToPlotWin_Click(object sender, RoutedEventArgs e)
        {
            plott window = new plott();
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
            Categorii window = new Categorii();
            window.Show();
            Close();
        }

    }
}


