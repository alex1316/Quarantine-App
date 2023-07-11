using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Smart_Quarantine_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Regex fullname = new Regex(@"^[A-Za-zα-ωΑ-ΩάέήίόύώϊϋΐΰΆΈΉΊΌΎΏΪΫ΅Ι΅Υ/.\-\s]+$");
        Regex address = new Regex(@"^[α-ωΑ-Ω0-9άέήίόύώϊϋΐΰΆΈΉΊΌΎΏΪΫ΅Ι΅Υ/.\-\s]+$");
        Regex phoneNumber = new Regex(@"^[0-9]{10}$");
        string message;
        string error_message;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            MessageBox.Show("Το πλάνο μετακινήσεων διαγράφηκε επιτυχώς", "Επιτυχής διαγραφή πλάνου μετακινήσεων");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") { MessageBox.Show("Δεν έχετε προγραμματίσει καμία μετακίνηση. Προγραμματίστε κάποια μετακίνηση και δοκιμάστε ξανα. ", "Δεν προγραμματίσατε καμία μετακίνηση"); }
            else
            {
                MessageBox.Show("Δημιουργήσατε επιτυχώς το πλάνο μετακινήσεών σας. Θα σταλούν τα ανάλογα μηνύματα στο 13033 τις ώρες που έχετε ορίσει.", "Επιτυχής δημιουργία πλάνου");
                Form7 your_movement = new Form7();
                your_movement.Show();
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                richTextBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Για να δημιουργήσετε το πλάνο μετακινήσεών σας, ακολουθήστε τις παρακάτω οδηγίες:\n\nΟνοματεπώνυμο: Συμπληρώστε το ονοματεπώνυμό σας, με ελληνικούς ή λατινικούς χαρακτήρες. Γίνονται δεκτοί και οι χαρακτήρες /, ., - και το κενό.\n\nΔιεύθυνση: Συμπληρώστε τη διεύθυνσή σας, με οδό και αριθμό, με ελληνικούς χαρακτήρες μόνο. Γίνονται δεκτοί και οι χαρακτήρες /, ., - και το κενό.\n\nΑριθμός κινητού: Συμπληρώστε τον αριθμό του κινήτού σας. Βεβαιωθείτε ότι έχετε πληκτρολογήσει ακριβώς 10 νούμερα.\n\nΜετακίνηση: Κάντε κλικ στο πεδίο και επιλέξτε μια από τις 6 διαθέσιμες μετακινήσεις.\n\nΜέσο μετακίνησης. Επιλέξτε ένα τουλάχιστον μέσο με το οποίο θα πραγματοποιήσετε τη μετακίνησή σας. Μπορείτε να επιλέξετε παραπάνω από ένα.\n\nΏρα: Κάντε κλικ στο πρώτο πεδίο και επιλέξτε την ώρα κατά την οποία θα πραγματοποιήσετε την μετακίνηση σας. Κάντε κλικ στο δεύτερο πεδίο και επιλέξτε τα λεπτά της ώρας κατά την οποία θα πραγματοποιήσετε τη μετακίνησή σας.\nΠ.χ. αν σκοπεύετε να μετακινηθείτε στις 16:20, επιλέξτε '16' στο πρώτο πεδίο και '20' στο δεύτερο.\n\nΣΗΜΑΝΤΙΚΟ: Λόγω της απαγόρευσης κυκλοφορίας από τις 21:00 μέχρι τις 04:59 που έχει επιβάλλει η κυβέρνηση, δεν μπορείτε να πραγματοποιήσετε τις μετακινήσεις με κωδικούς 2,3,4 και 5 από τις 21:00 μέχρι τις 04:59. Η εφαρμογή δεν θα σας επιτρέψει να προσθέσετε αυτές τις μετακινήσεις σε αυτές τις ώρες.\n\nΌταν τελειώσετε με τον προγραμματισμό της μετακίνησής σας, κάντε κλικ στο 'προσθήκη μετακίνησης'. Βεβαιωθείτε ότι έχετε συμπληρώσει όλα τα πεδία σύμφωνα με τις παραπάνω οδηγίες. Σε άλλη περίπτωση, θα σας εμφανιστεί μήνυμα λάθους με τις κατάλληλες υποδείξεις για να διορθώσετε ή/και να συμπληρώσετε τα στοιχεία της φόρμας μετακίνησης.\nΑν τα έχετε συμπληρώσει όλα σωστά, μόλις κάνετε κλικ στο 'προσθήκη μετακίνησης', θα εμφανιστεί ένα μήνυμα επιβεβαίωσης, και η μετακίνησή σας θα εισαχθεί στο πλαίσιο στα δεξιά του παραθύρου της εφαρμογής.\n\nΓια να προσθέσετε περισσότερες μετακινήσεις στο πλάνο σας, απλά επαναλάβετε την παραπάνω διαδικασία.\n\nΌταν είστε έτοιμοι, κάντε κλικ στο κουμπί 'Επικύρωση μετακινήσεων' κάτω δεξιά.\n\nΑν θέλετε να διαγράψετε το τρέχον πλάνο μετακινήσεών σας, κάντε κλικ στο κουμπί 'Διαγραφή μετακινήσεων'.\n\nΓια να μπορέσετε να επικυρώσετε τις μετακινήσεις σας, και να προγραμματίσετε την αποστολή των μηνυμάτων σας στο 13033, πρέπει να έχετε δηλώσει μία τουλάχιστον μετακίνηση.\n\nΜόλις δηλώσετε τις μετακινήσεις σας και πατήσετε το κουμπί 'Επικύρωση μετακινήσεων', θα σας εμφανιστεί ένα μήνυμα επιβεβαίωσης, και θα μεταφερθείτε σε ένα νέο παράθυρο, το οποίο θα σας δείχνει στον χάρτη την προτεινόμενη διαδρομή, την κίνηση στον δρόμο, την ώρα που πρέπει να επιστρέψετε, καθώς και ένα κουμπί για μεταφορά στην οθόνη αγοράς καφέ από μαγαζί, αν τυχόν χρειάζεστε καφέ.", "Βοήθεια");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox2.Text == "21" || comboBox2.Text == "22" || comboBox2.Text == "23" || comboBox2.Text == "00" || comboBox2.Text == "01" || comboBox2.Text == "02" || comboBox2.Text == "03" || comboBox2.Text == "04") && (comboBox1.Text == "2 - Μετάβαση σε σούπερ μάρκετ ή κατάστημα λιανικής" || comboBox1.Text == "3 - Μετάβαση σε τράπεζα" || comboBox1.Text == "4 - Παροχή βοήθειας σε ανήμπορο άτομο" || comboBox1.Text == "5 - Μετάβαση σε γάμο, βάφτιση, κηδεία, ή μετακίνηση χωρισμένων γονιών για να δουν το παιδί τους"))
            {
                MessageBox.Show("Η μετακίνηση αυτή απαγορεύεται, λόγω της απαγόρευσης κυκλοφορίας που έχει επιβάλλει η κυβέρνηση από τις 21:00 μέχτρι τις 05:00.", "Η μετακίνηση αυτή απαγορεύεται");
            }
            else
            {
                if (fullname.IsMatch(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text) && address.IsMatch(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox2.Text) && phoneNumber.IsMatch(textBox3.Text) && comboBox1.Text != "" && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true) && comboBox2.Text != "" && comboBox3.Text != "")
                {
                    message = comboBox1.Text[0] + " " + textBox1.Text + " " + textBox2.Text + "   " + "Ώρα: " + comboBox2.Text + ":" + comboBox3.Text + "\n\n";
                    richTextBox1.Text += message;
                    MessageBox.Show("Η μετακίνηση προστέθηκε με επιτυχία.", "Επιτυχής προσθήκη μετακίνησης");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (!fullname.IsMatch(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text)) { error_message += "Βάλατε μη επιτρεπόμενους χαρακτήρες στο πεδίο του ονοματεπωνύμου. Το πεδίο δέχεται μόνο ελληνικούς ή λατινικούς χαρακτήρες, καθώς και τους χαρακτήρες /, ., και -.\n"; }
                    if (String.IsNullOrWhiteSpace(textBox1.Text)) { error_message += "Αφήσατε το πεδίο του ονόματος κενό.\n"; }
                    if (!address.IsMatch(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox2.Text)) { error_message += "Βάλατε μη επιτρεπόμενους χαρακτήρες στο πεδίο της διεύθυνσης. Το πεδίο δέχεται μόνο αριθμούς και ελληνικούς χαρακτήρες, καθώς και τους χαρακτήρες /, ., και -.\n"; }
                    if (String.IsNullOrWhiteSpace(textBox2.Text)) { error_message += "Αφήσατε το πεδίο της διεύθυνσης κενό.\n"; }
                    if (!phoneNumber.IsMatch(textBox3.Text) && String.IsNullOrWhiteSpace(textBox3.Text)) { error_message += "Αφήσατε το πεδίο του αριθμού κενό.\n"; }
                    if (!phoneNumber.IsMatch(textBox3.Text) && !String.IsNullOrWhiteSpace(textBox3.Text)) { error_message += "Στο πεδίο του αριθμού, είτε βάλατε λιγότερα ή περισσότερα ψηφία από 10, είτε βάλατε κάποιο γράμμα ή σύμβολο. Το πεδίο αυτό δέχεται μόνο τα ψηφία 0-9.\n"; }
                    if (comboBox1.Text == "") { error_message += "Δεν επιλέξατε κάποια μετακίνηση.\n"; }
                    if (comboBox2.Text == "") { error_message += "Δεν επιλέξατε την ώρα της μετακίνησής σας.\n"; }
                    if (comboBox3.Text == "") { error_message += "Δεν επιλέξατε τα λεπτά της ώρας της μετακίνησής σας.\n"; }
                    if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) { error_message += "Δεν επιλέξατε κάποιο μέσο για τη μετακίνησης σας.\n"; }
                    MessageBox.Show("Έχετε κάνει τα εξής λάθη ή παραλείψεις στη συμπλήρωση των στοιχείων της μετακίνησης σας:\n\n" + error_message + "\n\nΔιορθώστε τα λάθη σας, συμπληρώστε ο,τι δεν έχετε συμπληρώσει, και δοκιμάστε να καταχωρήσετε τη μετακίνησή σας ξανά.", "Η φόρμα μετακίνησης δε συμπληρώθηκε σωστά");
                    error_message = "";
                }
            }
        }
    }
}
