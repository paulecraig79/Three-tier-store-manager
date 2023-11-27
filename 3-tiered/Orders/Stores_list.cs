using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Three_Tiered.Orders
{
    public class Stores_list : ObservableCollection<string>
    {
        public Stores_list()
        {
            string query = "select * from store";
            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "DE-Store";
            dbCon.UserName = "Java";
            dbCon.Password = "Java";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int ID = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    Add(Name + " " + ID);
                    

                }

            }
            dbCon.Close();
        }
    }
}
