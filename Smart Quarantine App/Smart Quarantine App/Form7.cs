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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 online_order = new Form6();
            online_order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int x = r.Next(1, 5);
            switch (x)
            {
                case 1:
                    label1.Text = "Κίνηση στον δρόμο: μηδαμινή";
                    break;
                case 2:
                    label1.Text = "Κίνηση στον δρόμο: χαμηλή";
                    break;
                case 3:
                    label1.Text = "Κίνηση στον δρόμο: μέτρια";
                    break;
                case 4:
                    label1.Text = "Κίνηση στον δρόμο: υψηλή";
                    break;
            }
            int y = r.Next(1, 5);
            switch (y)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("diadromi1.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("diadromi2.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("diadromi3.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("diadromi4.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("diadromi5.png");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Στο παράθυρο αυτό υπάρχουν πληροφορίες για το πλάνο μετακινήσεων σας.\n\n Στα αριστερά του παραθύρου βρίσκεται ο χάρτης της προτεινόμενης διαδρομής.\n\n Στα δεξιά του παραθύρου υπάρχουν χρήσιμες υποδείξεις για τις μετακινήσεις σας.\n\n Πάνω δεξιά εμφανίζεται η κίνηση στον δρόμο. Μπορεί να είναι μηδαμινή, χαμηλή, μεσαία ή υψηλή.\n\n Ακριβώς απο κάτω, εμφανίζεται η ώρα μέχρι την οποία πρέπει να επιστρέψετε σπίτι.\n\nΑν τυχόν χρειαστείτε καφέ, κάντε κλικ στο κουμπί 'Αγορά καφέ στο χέρι' και θα σας εμφανιστεί η οθόνη online αγοράς καφέ για να πραγματοποιήσετε την αγορά σας.\n\nΓια να κλείσετε το παράθυρο, κάντε κλικ στο κουμπί 'Κλείσιμο'.", "Βοήθεια");
        }
    }
}
