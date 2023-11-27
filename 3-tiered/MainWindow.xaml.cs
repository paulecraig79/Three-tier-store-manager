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
using SA_Three_Tiered.Customer;
using SA_Three_Tiered.Orders;

namespace SA_Three_Tiered
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SQL sql = new SQL();


            



            string query = "SELECT * FROM inventory WHERE Quantity < 3";
            sql.Checkamount(query);

        }

        private void Inventory_Button_Click(object sender, RoutedEventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void Orders_button_Click(object sender, RoutedEventArgs e)
        {
            Order_Menu menu = new Order_Menu();
            menu.Show();
        }
    }
}
