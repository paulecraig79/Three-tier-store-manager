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
    /// Interaction logic for Order_Menu.xaml
    /// </summary>
    public partial class Order_Menu : Window
    {
        public Order_Menu()
        {
            InitializeComponent();
        }

        private void Finance_Approved_Click(object sender, RoutedEventArgs e)
        {
            FA fa = new FA();
            fa.Show();
        }

        private void Store_Performance_Click(object sender, RoutedEventArgs e)
        {
            Stores store = new Stores();
            store.Show();
        }

        private void Item_Reports_Click(object sender, RoutedEventArgs e)
        {
            Item_Reports report = new Item_Reports();
            report.Show();
        }
    }
}
