using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD
{
    public partial class add_appointment : Form
    {

        public add_appointment()
        {
            InitializeComponent();
        }

        private void add_appointment_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Doctor f6 = new Add_Doctor();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient f3 = new add_patient();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }
    }
}
