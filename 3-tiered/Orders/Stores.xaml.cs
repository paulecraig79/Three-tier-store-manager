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

namespace SA_Three_Tiered.Orders
{
    /// <summary>
    /// Interaction logic for Stores.xaml
    /// </summary>
    public partial class Stores : Window
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void Store_Select_Click(object sender, RoutedEventArgs e)
        {
            SQL sql = new SQL();
            string text = Stores_Combo.Text;
            string ID = Regex.Replace(text, "[^.0-9]", "");

            string query = "SELECT COUNT(*) FROM orders WHERE Store_ID = " + ID;
            int order_amount = sql.CHECK(query);
            Store_Num_Of_Orders.Content = order_amount;

            string query2 = "SELECT SUM(total) FROM orders WHERE Store_ID = " + ID;
            Double money = sql.CHECK_PRICE(query2);
            Money.Content = "£" + money;
            
        }
    }
}
