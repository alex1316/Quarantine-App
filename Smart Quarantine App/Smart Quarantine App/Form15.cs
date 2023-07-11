using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Quarantine_App
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 order = new Form16();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 order = new Form16();
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 order = new Form16();
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 order = new Form16();
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 online_order = new Form6();
            online_order.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
