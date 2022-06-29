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
    public partial class add_patient : Form
    {
        public add_patient()
        {
            InitializeComponent();
        }

        private void add_patient_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Doctor  f6 = new Add_Doctor();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_appointment f4 = new add_appointment();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_apatient_record f9 = new add_apatient_record();
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }
    }
}
