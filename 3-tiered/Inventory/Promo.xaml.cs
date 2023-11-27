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
    /// Interaction logic for Promo.xaml
    /// </summary>
    public partial class Promo : Window
    {
        public Promo()
        {
            InitializeComponent();
        }


        private void Promo_Set_Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM inventory WHERE ID = " + ID_textbox.Text;
            SQL sql = new SQL();
            int check = sql.CHECK(query);
            if (check > 0)
            {
                string query2 = "UPDATE inventory SET promo = 1 WHERE ID = " + ID_textbox.Text;
                sql.ORDER(query2);
                if (B1G1F_Checkbox.IsChecked == true & _3for2_Checkbox.IsChecked == false & Free_Delivery_Checkbox.IsChecked == false)
                {
                    string query3 = "UPDATE promo SET B1G1F = 1, 3for2 = 0, free_delivery = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to Buy 1 get 1 free promo.");
                }
                else if (B1G1F_Checkbox.IsChecked == true & _3for2_Checkbox.IsChecked == true & Free_Delivery_Checkbox.IsChecked == false)
                {
                    string query3 = "UPDATE promo SET 3for2 = 1, B1G1F = 1, free_delivery = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to Buy 1 get 1 free and 3 for 2 promo.");
                }
                else if (B1G1F_Checkbox.IsChecked == true & _3for2_Checkbox.IsChecked == true & Free_Delivery_Checkbox.IsChecked == true)
                {
                    string query3 = "UPDATE promo SET 3for2 = 1, B1G1F = 1, free_delivery = 1 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to Buy 1 get 1 free, 3 for 2 and free delivery promo.");

                }
                else if (B1G1F_Checkbox.IsChecked == false & _3for2_Checkbox.IsChecked == true & Free_Delivery_Checkbox.IsChecked == false)
                {
                    string query3 = "UPDATE promo SET 3for2 = 1, B1G1F = 0, free_delivery = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to 3 for 2 promo.");
                }
                else if (B1G1F_Checkbox.IsChecked == false & _3for2_Checkbox.IsChecked == true & Free_Delivery_Checkbox.IsChecked == true)
                {
                    string query3 = "UPDATE promo SET 3for2 = 1, free_delivery = 1, B1G1F = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to 3 for 2 and free delivery promo.");
                }
                else if (B1G1F_Checkbox.IsChecked == false & _3for2_Checkbox.IsChecked == false & Free_Delivery_Checkbox.IsChecked == true)
                {
                    string query3 = "UPDATE promo SET free_delivery = 1, 3for2 = 0, B1G1F = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to free delivery promo.");
                }
                else if (B1G1F_Checkbox.IsChecked == true & _3for2_Checkbox.IsChecked == false & Free_Delivery_Checkbox.IsChecked == true)
                {
                    string query3 = "UPDATE promo SET free_delivery = 1, B1G1F = 1, 3for2 = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to Buy 1 get 1 free and free delivery promo.");

                }
                else if (B1G1F_Checkbox.IsChecked == false & _3for2_Checkbox.IsChecked == false & Free_Delivery_Checkbox.IsChecked == false)
                {
                    string query3 = "UPDATE promo SET 3for2 = 0, B1G1F = 0, free_delivery = 0 WHERE Item_ID = " + ID_textbox.Text;
                    sql.ORDER(query3);
                    MessageBox.Show("Item has been set to no promo.");
                }
            }

            else
            {
                MessageBox.Show("ERROR! Item isn't in stock or Incorrect Item ID");
            }
        }



        private void ID_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ID_textbox.Text == "")
            {
                Promo_Set_Button.IsEnabled = false;
            }
            else
            {
                Promo_Set_Button.IsEnabled = true;
            }
        }

        private void _3for2_Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            if(ID_textbox.Text == "")
            {
                Promo_Set_Button.IsEnabled = false;
            }
            else
            {
                Promo_Set_Button.IsEnabled = true;
            }
        }

        private void B1G1F_Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            if (ID_textbox.Text == "")
            {
                Promo_Set_Button.IsEnabled = false;
            }
            else
            {
                Promo_Set_Button.IsEnabled = true;
            }
        }

        private void Free_Delivery_Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            if (ID_textbox.Text == "")
            {
                Promo_Set_Button.IsEnabled = false;
            }
            else
            {
                Promo_Set_Button.IsEnabled = true;
            }
        }

        private void Promo_clear_button_Click(object sender, RoutedEventArgs e)
        {
            SQL sql = new SQL();
            string query = "Update inventory SET promo = 0 WHERE promo = 1";
            sql.ORDER(query);

            string query2 = "Update promo SET 3for2 = 0, B1G1F = 0, free_delivery = 0";
            sql.ORDER(query2);

            MessageBox.Show("All promos have been cleared.");


        }
    }
}
