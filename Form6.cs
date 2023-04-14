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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mysql
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
                MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                string sql1 = "select ProductID from ProductCatalog";
                MySqlCommand comm1 = new MySqlCommand(sql1, conn);
                MySqlDataReader reader1 = comm1.ExecuteReader();

                while (reader1.Read())
                {

                    listBox1.Items.Add(reader1[0].ToString());
                }
                reader1.Close();
                conn.Close();

                conn.Open();
                string sql2 = "select warehouseID from warehouse";
                MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader2 = comm2.ExecuteReader();

                while (reader2.Read())
                {

                    listBox2.Items.Add(reader2[0].ToString());
                }
                reader2.Close();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Error DB");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn1 = new Connection("localhost", "3307", "root", "root", "onlineorderbook");
                conn1.insertwarehouse(Convert.ToInt32(listBox1.SelectedItem), Convert.ToInt32(numericUpDown1.Value), (int)numericUpDown2.Value);
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn1 = new Connection("localhost", "3307", "root", "root", "onlineorderbook");
                conn1.uodatewarehouse(Convert.ToInt32(listBox1.SelectedItem), Convert.ToInt32(numericUpDown1.Value), (int)numericUpDown2.Value, Convert.ToInt32(listBox2.SelectedItem));
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
            catch
            {
                MessageBox.Show("Error");
            }
               
            
        }
    }
}
