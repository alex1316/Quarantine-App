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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }


        private void button47_Click(object sender, EventArgs e)
        {
            Form3 smart_home = new Form3();
            smart_home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button29.Visible == true && button41.Visible == true) 
            { 
                button24.Visible = false; 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button24.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button17.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button18.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button20.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button29.Visible == true && button41.Visible == true) 
            { 
                button22.Visible = false; 
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button22.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button25.Visible = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button27.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Visible = false;
            button45.Visible = false;
            button22.Visible = true;
            button24.Visible = true;
            button35.Visible = true;
            label5.Text = "Ο ΧΡΗΣΤΗΣ ΣΤΟ ΔΩΜΑΤΙΟ 1 ΕΡΓΑΖΕΤΑΙ";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            button29.Visible = true;
            button45.Visible = true;
            label5.Text = "Ο ΧΡΗΣΤΗΣ ΣΤΟ ΔΩΜΑΤΙΟ 1 ΔΕΝ ΕΡΓΑΖΕΤΑΙ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button31.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Visible = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button29.Visible == true && button41.Visible == true)
            {
                button35.Visible = false;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button35.Visible = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Visible = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button37.Visible = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Visible = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button39.Visible = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Visible = false;
            button46.Visible = false;
            button22.Visible = true;
            button24.Visible = true;
            button35.Visible = true;
            label6.Text = "Ο ΧΡΗΣΤΗΣ ΣΤΟ ΔΩΜΑΤΙΟ 2 ΕΡΓΑΖΕΤΑΙ";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button41.Visible = true;
            button46.Visible = true;
            label6.Text = "Ο ΧΡΗΣΤΗΣ ΣΤΟ ΔΩΜΑΤΙΟ 2 ΔΕΝ ΕΡΓΑΖΕΤΑΙ";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button33.Visible = true;
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }
    }
}
