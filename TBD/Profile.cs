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
using System.Data;

namespace TBD
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=TBD4;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome f8 = new Welcome();
            f8.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
