using MySql.Data.MySqlClient;
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

namespace SA_Three_Tiered
{
    /// <summary>
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : Window
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Inventory_Search search = new Inventory_Search();
            search.Show();

        }

        private void Order_button_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void Pricing_button_Click(object sender, RoutedEventArgs e)
        {
            Manager_Log_in login = new Manager_Log_in();
            login.Show();
        }
    }
}
