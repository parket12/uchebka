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
    public partial class KassaPage : Window
    {
        private uchEntities db = new uchEntities();
        public KassaPage()
        {
            InitializeComponent();
            EmployDgr.ItemsSource = db.Product.ToList();
            CategoryCBx.ItemsSource = db.ProductCategory.ToList();
            InsureCBx.ItemsSource = db.InsuranceCompany.ToList();
            PlotCBx.ItemsSource = db.Plot.ToList();
            FiltrCBx.ItemsSource = db.ProductCategory.ToList();

        }

        private void EmployDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                var selected = EmployDgr.SelectedItem as Product;
                NameProdTBx.Text = selected.NameOfProduct;
                PriceTBx.Text = selected.Price.ToString();
                CategoryCBx.SelectedItem = selected.ProductCategory;
                InsureCBx.SelectedItem = selected.InsuranceCompany;
                PlotCBx.SelectedItem = selected.Plot;
            }
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (EmployDgr.SelectedItem != null)
            {
                db.Product.Remove(EmployDgr.SelectedItem as Product);
                db.SaveChanges();
                EmployDgr.ItemsSource = db.Product.ToList();
            }
        }

        private void UpdBut_Click(object sender, RoutedEventArgs e)
        {
            var sur = new PohoronnoeBuro.Product();

            if (string.IsNullOrWhiteSpace(NameProdTBx.Text))
            {
                MessageBox.Show("Поле 'Название продукта' не должно быть пустым.");
                return;
            }

            if (!Regex.IsMatch(NameProdTBx.Text, "^[а-яА-Я]*$"))
            {
                MessageBox.Show("Поле 'Название продукта' должно содержать только буквы.");
                return;
            }
            sur.NameOfProduct = NameProdTBx.Text;


            if (string.IsNullOrWhiteSpace(PriceTBx.Text))
            {
                MessageBox.Show("Поле 'Цена' не должно быть пустой.");
                return;
            }
            if (!Regex.IsMatch(PriceTBx.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Поле 'Цена' должно содержать только цифры.");
                return;
            }
            sur.Price = Convert.ToInt32(PriceTBx.Text);

            sur.ProductCategory_ID = (CategoryCBx.SelectedItem as ProductCategory).ID_ProductCategory;
            sur.InsuranceCompany_ID = (InsureCBx.SelectedItem as InsuranceCompany).ID_InsuranceCompany;
            sur.Plot_ID = (PlotCBx.SelectedItem as Plot).ID_Plot;
            db.SaveChanges();
            EmployDgr.ItemsSource = db.Product.ToList();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            var sur = new PohoronnoeBuro.Product();

            if (string.IsNullOrWhiteSpace(NameProdTBx.Text))
            {
                MessageBox.Show("Поле 'Название продукта' не должно быть пустым.");
                return;
            }

            if (!Regex.IsMatch(NameProdTBx.Text, "^[а-яА-Я]*$"))
            {
                MessageBox.Show("Поле 'Название продукта' должно содержать только буквы.");
                return;
            }
            sur.NameOfProduct = NameProdTBx.Text;


            if (string.IsNullOrWhiteSpace(PriceTBx.Text))
            {
                MessageBox.Show("Поле 'Цена' не должно быть пустой.");
                return;
            }
            if (!Regex.IsMatch(PriceTBx.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Поле 'Цена' должно содержать только цифры.");
                return;
            }
            sur.Price = Convert.ToInt32(PriceTBx.Text);

            sur.ProductCategory_ID = (CategoryCBx.SelectedItem as ProductCategory).ID_ProductCategory;
            sur.InsuranceCompany_ID = (InsureCBx.SelectedItem as InsuranceCompany).ID_InsuranceCompany;
            sur.Plot_ID = (PlotCBx.SelectedItem as Plot).ID_Plot;


            db.Product.Add(sur);
            db.SaveChanges();
            EmployDgr.ItemsSource = db.Product.ToList();
        }

        private void SearchBut_Click(object sender, RoutedEventArgs e)
        {
            var text = SearchTBx.Text;
            EmployDgr.ItemsSource = db.Product.ToList().Where(item => item.NameOfProduct.Contains(text));
        }

        private void RexetBut_Click(object sender, RoutedEventArgs e)
        {
            EmployDgr.ItemsSource = db.Product.ToList();
        }

        private void FiltrCBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = FiltrCBx.SelectedItem as ProductCategory;
            EmployDgr.ItemsSource = db.Product.ToList().Where(it => it.ProductCategory == selected);
        }

        private void ToInsureWin_Click(RoutedEventArgs e)
        {

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



        private void ToInfoWin_Click(object sender, RoutedEventArgs e)
        {
            Infoooo window = new Infoooo();
            window.Show();
            Close();
        }
    }
}
