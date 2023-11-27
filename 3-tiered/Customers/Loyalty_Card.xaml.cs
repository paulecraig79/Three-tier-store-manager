using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SA_Three_Tiered.Customer
{
    /// <summary>
    /// Interaction logic for Loyalty_Card.xaml
    /// </summary>
    public partial class Loyalty_Card : Window
    {



        public Loyalty_Card()
        {
            InitializeComponent();



        }

        private void Set_loyal_button_Click(object sender, RoutedEventArgs e)
        {
            string text = Loyal_Combo.Text;
            string ID = Regex.Replace(text, "[^.0-9]", "");
            string query = "UPDATE customer SET loyalty_card = 5 WHERE ID = " + ID;
            SQL sql = new SQL();
            sql.ORDER(query);
            MessageBox.Show(text + " has been awarded a loyalty card for 5 uses.");
            Close();
        }
    }
}
