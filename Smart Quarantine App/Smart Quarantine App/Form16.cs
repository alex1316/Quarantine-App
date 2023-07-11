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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        String error_message;
        private void button1_Click(object sender, EventArgs e)
        {
            using (Form17 cpl = new Form17())
            {
                if (!String.IsNullOrWhiteSpace(comboBox1.Text) && !String.IsNullOrWhiteSpace(comboBox2.Text) && !String.IsNullOrWhiteSpace(comboBox3.Text) && !String.IsNullOrWhiteSpace(comboBox4.Text) && !String.IsNullOrWhiteSpace(comboBox5.Text) && !String.IsNullOrWhiteSpace(comboBox6.Text) && textBox1.Text.Length == 16 && textBox2.Text.Length == 3 && textBox3.Text.Length > 0) 
                { 
                this.Hide();
                        cpl.type = this.comboBox1.SelectedItem.ToString();
                        cpl.state = this.comboBox5.SelectedItem.ToString();
                        cpl.number = Convert.ToInt32(textBox3.Text);
                        cpl.card_number = comboBox4.SelectedItem.ToString();
                        cpl.datem = comboBox2.SelectedItem.ToString();
                        cpl.datey = comboBox3.SelectedItem.ToString();
                        cpl.card_number = textBox1.Text;
                        cpl.security = textBox2.Text;
                        cpl.delivery = this.comboBox6.SelectedItem.ToString();
                        cpl.ShowDialog();
                }
                else 
                {
                    error_message = "";
                    if (String.IsNullOrWhiteSpace(comboBox1.Text)) { error_message += "Δεν επιλέξατε αν θέλετε τον καφέ σας σκέτο, μέτριο ή γλυκό.\n"; }
                    if (String.IsNullOrWhiteSpace(comboBox2.Text)) { error_message += "Δεν συμπληρώσατε τον μήνα λήξης της πιστωτικής σας κάρτας.\n"; }
                    if (String.IsNullOrWhiteSpace(comboBox3.Text)) { error_message += "Δεν συμπληρώσατε το έτος λήξης της πιστωτικής σας κάρτας.\n"; }
                    if (String.IsNullOrWhiteSpace(comboBox4.Text)) { error_message += "Δεν επιλέξατε αν η κάρτα σας είναι Visa, MasterCard ή Maestro.\n"; }
                    if (String.IsNullOrWhiteSpace(comboBox5.Text)) { error_message += "Δεν επιλέξατε αν θέλετε τον καφέ σας ζεστό ή κρύο.\n"; }
                    if (String.IsNullOrWhiteSpace(comboBox6.Text)) { error_message += "Δεν επιλέξατε τον τρόπο παραλαβής της παραγγελίας σας.\n"; }
                    if (String.IsNullOrWhiteSpace(textBox1.Text)) { error_message += "Βάλατε λιγότερα ή περισσότερα από 16 ψηφία στο πεδίο του αριθμού της πιστωτικής κάρτας.\n"; }
                    if (String.IsNullOrWhiteSpace(textBox2.Text)) { error_message += "Δεν συμπληρώσατε τον κωδικό ασφαλείας της πιστωτικής σας κάρτας.\n"; }
                    if (String.IsNullOrWhiteSpace(textBox3.Text)) { error_message += "Δεν επιλέξατε πόσους καφέδες θέλετε.\n"; }
                    MessageBox.Show("Κάνατε τα εξής λάθη ή παραλείψεις στη συμπλήρωση της παραγγελίας σας:\n\n"+error_message+"\n\nΣυμπληρώστε τα κενά πεδία και προσπαθήστε να πραγματοποιήσετε την παραγγελία σας ξανά.", "Η παραγγελία δεν συμπληρώθηκε σωστά");
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 select_order = new Form15();
            select_order.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Για να καταχωρήσετε την παραγγελία σας, ακολουθήστε τα παρακάτω βήματα:\n\nΣτο πεδίο 'τύπος' επιλέξτε αν θέλετε ο καφές σας να είναι σκέτος, μέτριος ή γλυκός.\n\nΣτο πεδίο 'θερμοκρασία', επιλέξτε αν θέλετε ο καφές σας να είναι ζεστός ή κρύος.\n\nΣτο πεδίο 'ποσότητα' επιλέξτε πόσους καφέδες θέλετε.\n\nΣτο πεδίο 'είδος κάρτας', επιλέξτε αν η πιστωτική σας κάρτα είναι Visa, MasterCard ή Maestro.\n\nΣτο πεδίο 'αριθμός κάρτας', πληκτρολογήστε τον 16-ψήφιο αριθμό της κάρτας σας.\n\nΣτο πεδίο 'ημερομηνία λήξης', επιλέξτε τον μήνα και το έτος λήξης της κάρτας σας, όπως αναγράφονται στην μπροστινή της όψη.\n\nΣτο πεδίο 'αριθμός ασφαλείας', συμπληρώστε τον τριψήφιο αριθμό ασφαλείας της κάρτας σας, όπως αναγράφεται στην πίσω όψη της.\n\nΤέλος, στο πεδίο 'τρόπος παραλαβής', επιλέξτε αν θέλετε να παραλάβετε την παραγγελία σας με take away, ή να σας έρθει στο σπίτι με delivery.\n\nΌταν είστε έτοιμοι, πατήστε το κουμπί 'επόμενο', για να ολοκληρώσετε την παραγγελία σας.\n\nΓια επιστροφή στο προηγούμενο παράθυρο, κάντε κλικ στο βελάκι πάνω αριστερά.\n\nΓια κλείσιμο του παραθύρου, κάντε κλικ στο Χ πάνω δεξιά.", "Βοήθεια");
        }
    }
}
