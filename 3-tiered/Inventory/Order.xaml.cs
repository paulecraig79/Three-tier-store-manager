using System;
using System.Collections;
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
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Item_button_Click(object sender, RoutedEventArgs e)
        {
            SQL sql = new SQL();
            if (ID_Radio.IsChecked == true & Item_Name.IsChecked == false)
            {

                string check = "SELECT Quantity FROM inventory WHERE ID = " + Item_Ident.Text;
                int amount = sql.CHECK(check);
                int total = Int32.Parse(Quantity_text.Text) + amount;
                string query = "UPDATE inventory SET Quantity = " + total + " WHERE ID = " + Item_Ident.Text;
                sql.ORDER(query);

                MessageBox.Show("Item had a quantity of " + amount + " and now has a quantity of " + total);



            }

            else if (Item_Name.IsChecked == true & ID_Radio.IsChecked == false)
            {
                string check = "SELECT Quantity FROM inventory WHERE Item = '" + Item_Ident.Text+"'";
                int amount = sql.CHECK(check);
                int total = Int32.Parse(Quantity_text.Text) + amount;
                string query = "UPDATE inventory SET Quantity = " + total + " WHERE Item = '" + Item_Ident.Text+"'";
                sql.ORDER(query);
                MessageBox.Show("Item had a quantity of " + amount + " and now has a quantity of " + total);
            }
        }

        private void ID_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
