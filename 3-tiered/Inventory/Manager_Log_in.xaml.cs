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
    /// Interaction logic for Manager_Log_in.xaml
    /// </summary>
    public partial class Manager_Log_in : Window
    {
        public Manager_Log_in()
        {
            InitializeComponent();
        }

        private void Log_In_Click(object sender, RoutedEventArgs e)
        {
            SQL sql = new SQL();
            string query = "SELECT Manager FROM login WHERE User_Name = '" + UserName.Text + "' AND password = '" + Pass.Password + "'";
            int manger = sql.CheckManagerLogIn(query);
            if (manger == 1 )
            {
                Price price = new Price();
                price.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
