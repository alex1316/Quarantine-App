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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        public string type;
        public string state;
        public int number;
        public string card_type;
        public string card_number;
        public string datem;
        public string datey;
        public string security;
        public string delivery;
        private void button3_Click(object sender, EventArgs e)
        {
            Form16 order = new Form16();
            order.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας καταχωρήθηκε με επιτυχία", "Επιτυχής καταχώρηση παραγγελίας");
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "ΤΥΠΟΣ ΚΑΦΕ: " + type;
            richTextBox1.AppendText(Environment.NewLine + "ΖΕΣΤΟΣ Ή ΚΡΥΟΣ: " + state);
            richTextBox1.AppendText(Environment.NewLine + "ΣΥΝΟΛΙΚΟ ΚΟΣΤΟΣ: " + Convert.ToString(number * 1.9)+ "€") ;
            richTextBox1.AppendText(Environment.NewLine + "Ο ΑΡΙΘΜΟΣ ΤΗΣ ΚΑΡΤΑΣ: " + card_number);
            richTextBox1.AppendText(Environment.NewLine + "ΗΜΕΡΟΜΗΝΙΑ ΛΗΞΗΣ: " + datem + " / " + datey);
            richTextBox1.AppendText(Environment.NewLine + "ΤΡΟΠΟΣ ΠΑΡΑΛΑΒΗΣ: " + delivery);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Στο παράθυρο αυτό εμφανίζεται η επισκόπηση της παραγγελίας σας.\n\nΑν είστε ικανοποιημένοι και επιθυμείτε να προχωρήσετε με την παραγγελία, κάντε κλικ στο κουμπί 'ολοκλήρωση παραγγελίας'.\n\nΓια επιστροφή στο προηγούμενο παράθυρο, κάντε κλικ στο βελάκι πάνω αριστερά.\n\nΓια κλείσιμο του παραθύρου, κάντε κλικ στο Χ πάνω δεξιά.", "Βοήθεια");
        }
    }
}
