using MySql.Data.MySqlClient;
using System.Data;

namespace TBD
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=TBD4;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Create f5 = new Create();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }
    }
    }
