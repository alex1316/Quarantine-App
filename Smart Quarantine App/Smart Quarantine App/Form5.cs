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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Random r = new Random();
        Form9 are_you_ok = new Form9();
        private void button1_Click(object sender, EventArgs e)
        {
            Form10 giatros = new Form10();
            giatros.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 psonia = new Form11();
            psonia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 want_to_talk = new Form8();
            want_to_talk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 help_about_app = new Form12();
            help_about_app.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int room_number = r.Next(1, 6);
            int fallChance = r.Next(1, 21);
            switch (room_number)
            {
                case 1:
                    pictureBox6.Location = new Point(200, 136);
                    break;
                case 2:
                    pictureBox6.Location = new Point(563, 109);
                    break;
                case 3:
                    pictureBox6.Location = new Point(1023, 134);
                    break;
                case 4:
                    pictureBox6.Location = new Point(143, 501);
                    break;
                case 5:
                    pictureBox6.Location = new Point(634, 492);
                    break;
            }
            timer1.Interval = r.Next(1000, 5001);
            if (fallChance == 1)
            {
                timer1.Enabled = false;
                pictureBox6.Size = new System.Drawing.Size(199, 136);
                pictureBox6.Image = Image.FromFile("oldman_fallen.png");
                are_you_ok.Show();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DarkRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.DarkRed;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.DarkRed;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }
    }
}
