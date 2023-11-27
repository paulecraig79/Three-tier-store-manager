using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SA_Three_Tiered
{
    internal class SQL
    {
        


        public void QUERY(string query, TextBox output)
        {
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
                    string Item = reader.GetString(1);
                    int Quantity = reader.GetInt32(2);
                    double Price = reader.GetDouble(3);
                    output.Text = "ID = " + ID + " Item = " + Item + " Quantity = " + Quantity + " Price = " + Price;
                }

            }
            dbCon.Close();

        }

        public void Trending_Items(string query, Label text1, Label text2, Label text3)
        {
            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "DE-Store";
            dbCon.UserName = "Java";
            dbCon.Password = "Java";

            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    string item = reader.GetString(0);
                    if (i == 0)
                    {
                        text1.Content = item;
                    }
                    else if (i == 1)
                    {
                        text2.Content = item;
                    }
                    else if (i == 2)
                    {
                        text3.Content = item;
                    }
                    i++;
                }
            }
            dbCon.Close();

        }

        public void Checkamount(string query)
        {
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
                    string Item = reader.GetString(1);
                    int Quantity = reader.GetInt32(2);
                    double Price = reader.GetDouble(3);
                    MessageBox.Show("Warning! " + Item + " has low quantity. Manager has been emailed.");
                }
                
            }
            dbCon.Close();
           

        }

        public void ORDER(string query)
        {
            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "DE-Store";
            dbCon.UserName = "Java";
            dbCon.Password = "Java";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
            }
            dbCon.Close();

        }

        public int CHECK(string query)
        {
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
                    int Quantity = reader.GetInt32(0); 
                    reader.Close();
                    dbCon.Close();
                    return Quantity;
                }

            }

            return 0;
        }

        public double CHECK_PRICE(string query)
        {
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
                    double Price = reader.GetDouble(0);
                    dbCon.Close();
                    return Price;
                }

            }

            return 0;
        }
        public int CheckManagerLogIn(string query)
        {
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

                    int privledge = reader.GetInt32(0);
                    dbCon.Close();
                    return privledge;
                }

            }

            return 0;


        }
    }

}



