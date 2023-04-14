using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Connection conn1 = new Connection("localhost", "3307", "root", "root", "onlineorderbook");
            string name = textBox2.Text;
            conn1.insertProductCatalog(name);
            textBox2.Text = "";   
        }
    }
}
