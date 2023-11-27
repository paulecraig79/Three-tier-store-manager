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
    /// Interaction logic for FA.xaml
    /// </summary>
    public partial class FA : Window
    {
        public FA()
        {
            InitializeComponent();

            string query = "SELECT COUNT(*) FROM orders WHERE Finance_Approved = 1";
            SQL sql = new SQL();
            int num = sql.CHECK(query);
            No_of_FA.Content = num;
        }
    }
}
