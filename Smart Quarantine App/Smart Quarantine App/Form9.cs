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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        byte tick = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            tick = 0;
            Form10 giatros = new Form10();
            giatros.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            tick = 0;
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 10)
            {
                timer2.Enabled = false;
                tick = 0;
                MessageBox.Show("Αργήσατε να απαντήσετε. Ίσως σας συνέβη κάτι. Το ΕΚΑΒ και τα κοντινά σας πρόσωπα έχουν ενημερωθεί.");
                this.Close();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }
}
