using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            
        }
       

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            string sql1 = "select * from Orders join Buyer on Buyer.BuyerID=Orders.BuyerID";
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = comm1.ExecuteReader();
            DataTable dt = new DataTable();
            
            ListViewItem item1 = null;
            while (reader1.Read())
            {
                item1 = new ListViewItem(new String[] { reader1[0].ToString(), reader1[3].ToString(), reader1[4].ToString(), reader1[6].ToString(), reader1[8].ToString(), reader1[9].ToString() });

                listView1.Items.Add(item1);
                
                //listView1.Columns.Add(reader1.GetName(0), 0, HorizontalAlignment.Left);
            }

            reader1.Close();

            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql1;
            if (checkBox1.Checked)
            {
                      

                sql1 = "select * from Orders join Buyer on Buyer.BuyerID=Orders.BuyerID order by OrderPrice ASC"; 
                
            }
            else
            {
                sql1 = "select * from Orders join Buyer on Buyer.BuyerID=Orders.BuyerID order by OrderPrice DESC";

            }

            MySqlCommand comm1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = comm1.ExecuteReader();
            DataTable dt = new DataTable();

            ListViewItem item1 = null;
            while (reader1.Read())
            {
                item1 = new ListViewItem(new String[] { reader1[0].ToString(), reader1[3].ToString(), reader1[4].ToString(), reader1[6].ToString(), reader1[8].ToString(), reader1[9].ToString() });

                listView1.Items.Add(item1);

            }

            reader1.Close();

            conn.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql1;
            if (checkBox2.Checked)
            {


                sql1 = "select * from Orders join Buyer on Buyer.BuyerID=Orders.BuyerID order by OrderDate ASC";

            }
            else
            {
                sql1 = "select * from Orders join Buyer on Buyer.BuyerID=Orders.BuyerID order by OrderDate DESC";

            }

            MySqlCommand comm1 = new MySqlCommand(sql1, conn);

            MySqlDataReader reader1 = comm1.ExecuteReader();
            DataTable dt = new DataTable();

            ListViewItem item1 = null;
            while (reader1.Read())
            {
                item1 = new ListViewItem(new String[] { reader1[0].ToString(), reader1[3].ToString(), reader1[4].ToString(), reader1[6].ToString(), reader1[8].ToString(), reader1[9].ToString() });

                listView1.Items.Add(item1);

            }

            reader1.Close();

            conn.Close();
        }
    }
}
