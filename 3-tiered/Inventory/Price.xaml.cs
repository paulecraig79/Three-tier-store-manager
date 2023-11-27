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
    /// Interaction logic for Price.xaml
    /// </summary>
    public partial class Price : Window
    {
        public Price()
        {
            InitializeComponent();
        }

        private void Set_Button_Click(object sender, RoutedEventArgs e)
        {

            SQL sql = new SQL();

            if (ID_Radio.IsChecked == true & Item_Name.IsChecked == false)
            {

                string check = "SELECT price FROM inventory WHERE ID = " + Item_identity.Text;
                double amount = sql.CHECK_PRICE(check);
                double new_amount = double.Parse(Price_Text.Text);
                string query = "UPDATE inventory SET price = " + new_amount + " WHERE ID = " + Item_identity.Text;
                sql.ORDER(query);

                MessageBox.Show("Item had a price of " + amount + " and now has a price of " + new_amount);
            }

            else if (Item_Name.IsChecked == true & ID_Radio.IsChecked == false)
            {

                string check = "SELECT price FROM inventory WHERE item = '" + Item_identity.Text+"'";
                double amount = sql.CHECK_PRICE(check);
                double new_amount = double.Parse(Price_Text.Text);
                string query = "UPDATE inventory SET price = " + new_amount + " WHERE item = '" + Item_identity.Text+"'";
                sql.ORDER(query);

                MessageBox.Show("Item had a price of " + amount + " and now has a price of " + new_amount);

            }

        }

        private void ID_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Promo_set_Click(object sender, RoutedEventArgs e)
        {
            Promo promo = new Promo();
            promo.Show();
        }
    }
}
