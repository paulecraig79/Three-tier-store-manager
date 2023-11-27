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

namespace SA_Three_Tiered.Orders
{
    /// <summary>
    /// Interaction logic for Item_Reports.xaml
    /// </summary>
    public partial class Item_Reports : Window
    {
        public Item_Reports()
        {
            InitializeComponent();

            string query = "SELECT inventory.Item, orders.Item_ID, COUNT(Item_ID) FROM `orders` INNER JOIN inventory ON orders.Item_ID=inventory.ID GROUP BY Item_ID ORDER BY `COUNT(Item_ID)` DESC LIMIT 3;";
            SQL sql = new SQL ();
            sql.Trending_Items(query,Item_1,Item_2,Item_3);
           

        }
    }
}
