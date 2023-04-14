namespace mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.ShowDialog();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string admin = textBox1.Text;
            if(admin == "admin")
            {
                panel1.Visible = false;
                button3.Visible = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}