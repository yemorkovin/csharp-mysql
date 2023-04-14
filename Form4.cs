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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
                MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                string sql1 = "select BuyerID, Name from Buyer";
                MySqlCommand comm1 = new MySqlCommand(sql1, conn);
                MySqlDataReader reader1 = comm1.ExecuteReader();
               
                while (reader1.Read())
                {

                    listBox1.Items.Add(reader1[0].ToString());
                }
                reader1.Close();
                conn.Close();

                conn.Open();

                string sql2 = "select * from ProductCatalog";
                MySqlCommand comm2 = new MySqlCommand(sql2, conn);
                MySqlDataReader reader2 = comm2.ExecuteReader();

                while (reader2.Read())
                {

                    listBox2.Items.Add(reader2[0].ToString() + "-"+ reader2[1].ToString());
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
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection conn1 = new Connection("localhost", "3307", "root", "root", "onlineorderbook");

                int buyerID = int.Parse(listBox1.SelectedItem.ToString());
                int desc = ((int)numericUpDown2.Value);
                string date = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
                //decimal price = numericUpDown1.Value;
                conn1.insertOrder(buyerID, desc, date, Convert.ToDecimal(label3.Text));
                MessageBox.Show("Данные успешно добавлены!");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strings = listBox2.SelectedItem.ToString().Split('-');
            int ProductID = Convert.ToInt32(strings[0]);

            string connectionString = "server=localhost;port=3307;uid=root;pwd=root;database=onlineorderbook";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql1 = "select ProductPrice from warehouse where ProductID ="+ ProductID;
            MySqlCommand comm1 = new MySqlCommand(sql1, conn);
            MySqlDataReader reader1 = comm1.ExecuteReader();

            while (reader1.Read())
            {
                label3.Text = reader1[0].ToString();
            }
            reader1.Close();
            conn.Close();
        }
    }
}
