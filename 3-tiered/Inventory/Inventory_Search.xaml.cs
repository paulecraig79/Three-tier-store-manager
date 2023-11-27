using MySql.Data.MySqlClient;
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
    /// Interaction logic for Inventory_Search.xaml
    /// </summary>
    public partial class Inventory_Search : Window
    {
        public Inventory_Search()
        {
            InitializeComponent();
        }



        public void ID_Checked(object sender, RoutedEventArgs e)
        {
            
        }




        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            SQL sql = new SQL();
                
            if (ID_Radio.IsChecked == true & Item_Name.IsChecked == false)
                
            {
                 

                string query = "SELECT * FROM inventory WHERE ID = " + Query.Text;
                sql.QUERY(query, Search_Text);
            }
                
            else if(Item_Name.IsChecked == true & ID_Radio.IsChecked == false)
                
            {
                    
                string query = "SELECT * FROM inventory WHERE Item = '" + Query.Text +"'";
                sql.QUERY(query, Search_Text);
            }

        }


    }
}
