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
    public partial class Add_Doctor : Form
    {
        public Add_Doctor()
        {
            InitializeComponent();
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
            add_patient  f3 = new add_patient();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_appointment f4 = new add_appointment();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }
    }
}
