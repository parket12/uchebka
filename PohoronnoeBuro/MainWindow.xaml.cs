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
using PohoronnoeBuro.uchDataSetTableAdapters;

namespace PohoronnoeBuro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeesTableAdapter adapter = new EmployeesTableAdapter();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = adapter.GetData().Rows;
            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][3].ToString() == LoginTbx.Text &&
                    allLogins[i][4].ToString() == PasswordTbx.Password)
                {
                    int role = (int)allLogins[i][5];
                    switch (role)
                    {
                        case 1:
                            AdminPage adm = new AdminPage();
                            Close();
                            adm.Show();
                            return;
                        case 2:
                            KassaPage kassa = new KassaPage();
                            Close();
                            kassa.Show();
                            break;
                    }
                }
                else
                {
                   TextTBl.Text = "Неверный логин или пароль, повторите попытку снова";
                }
            }
        }
    }
}
