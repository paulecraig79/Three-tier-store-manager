using K4os.Compression.LZ4.Streams.Abstractions;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Three_Tiered.Customer
{
    public class Candidates : ObservableCollection<string>
    {
        public Candidates()
        {
            string query = "select * from customer WHERE order_amount > 10";
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
                    string address = reader.GetString(2);
                    int order_amount = reader.GetInt32(3);
                    int loyalty_card = reader.GetInt32(4);

                    if(loyalty_card == 0)
                    {
                        Add(Name + " " + ID);
                    }

                }

            }
            dbCon.Close();
        }
    }

}

