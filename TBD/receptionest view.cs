using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5;

namespace TBD
{
    public partial class receptionest_view : Form
    {
        public receptionest_view()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient  f3 = new add_patient();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f4 = new Form1();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Add_Doctor  f6 = new Add_Doctor();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Profile f7 = new Profile();
            f7.Show();
        }
    }
}
