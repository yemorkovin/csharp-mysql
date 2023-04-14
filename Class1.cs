using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mysql
{
    class Connection
    {
        MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
        public Connection(string host, string port, string user, string password, string db)
        {
       
            string connectionString = "server="+host+";port="+port+";uid="+user+";pwd="+password+";database="+db;
            
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        public void insertProductCatalog(string name)
        {
            string sql1 = "INSERT INTO ProductCatalog (ProductName) values ('" + name + "')";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);

            comm1.ExecuteNonQuery();
            conn.Close();

        }
        public void insertOrder(int BuyerID, int OrderDESC, string OrderDate, decimal OrderPrice)
        {
            string sql1 = "INSERT INTO Orders " +
                "(BuyerID, OrderDESC, OrderDate, OrderPrice) " +
                "values " +
                "(" + BuyerID + ", "+ OrderDESC + ", '"+ OrderDate + "', "+ OrderPrice + ")";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);

            comm1.ExecuteNonQuery();
            conn.Close();

        }

        public void insertBuyer(string name, string surname, string patronymic, int tel, string gender)
        {
            string sql1 = "INSERT INTO Buyer " +
                "(Name, Surname, Patronymic, TelephoneNumber, Gender) " +
                "values " +
                "('" + name + "', '" + surname + "','" + patronymic + "', " + tel + ", '" + gender + "')";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            comm1.ExecuteNonQuery();

            conn.Close();

        }

        public void insertwarehouse(int ProductID, int price, int count)
        {
            string sql1 = "INSERT INTO warehouse " +
                "(ProductID, ProductPrice, ProductCount) " +
                "values " +
                "('" + ProductID + "', '" + price + "','" + count + "')";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            comm1.ExecuteNonQuery();

            conn.Close();

        }

        public void uodatewarehouse(int ProductID, int price, int count, int id)
        {
      
            string sql1 = "UPDATE warehouse SET ProductID = "+ ProductID + ", ProductPrice = "+ price + ", ProductCount = "+ count +
            " WHERE WarehouseID = " + id;
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            comm1.ExecuteNonQuery();

            conn.Close();

        }
    }

}
