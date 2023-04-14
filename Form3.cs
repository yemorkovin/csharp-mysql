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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn1 = new Connection("localhost", "3307", "root", "root", "onlineorderbook");
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string patronymic = textBox3.Text;
            int tel = ((int)numericUpDown1.Value);

            string gender = textBox4.Text;


            conn1.insertBuyer(name, surname, patronymic, tel, gender);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            numericUpDown1.Value = 0;

        }
    }
}
