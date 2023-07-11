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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 select_order = new Form15();
            select_order.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) ΓΙΑ ΝΑ ΠΡΑΓΜΑΤΟΠΟΙΗΣΕΤΕ ΜΙΑ ΠΑΡΑΓΓΕΛΙΑ, ΠΑΤΗΣΤΕ ΤΟ ΚΟΥΜΠΙ 'ΠΑΡΑΓΓΕΛΙΑ' ΣΤΟ ΚΕΝΤΡΙΚΟ ΜΕΝΟΥ.\n\n 2) EΠΕΙΤΑ, ΔΙΑΛΕΞΤΕ ΤΟ ΠΡΟΪΟΝ ΠΟΥ ΕΠΙΘΥΜΙΤΕ ΜΕΤΑΞΥ CAPUCCINO, ESPRESSO, LATTE ΚΑΙ ΕΛΛΗΝΙΚΟ, ΚΑΙ ΜΕΤΑΒΕΙΕΤΕ ΣΤΙΣ 'ΠΑΡΑΓΓΕΛΙΕΣ'. \n 3) ΕΚΕΙ, ΕΠΙΛΕΞΤΕ ΠΟΣΟΥΣ ΚΑΦΕΔΕΣ ΘΕΛΕΤΕ, ΠΏΣ ΤΟΥΣ ΘΕΛΕΤΕ, ΤΑ ΣΤΟΙΧΕΙΑ ΤΗΣ ΠΙΣΤΩΤΙΚΗΣ ΣΑΣ ΚΑΡΤΑΣ, ΚΑΘΩΣ ΚΑΙ ΤΟΝ ΤΡΟΠΟ ΠΑΡΑΛΑΒΗΣ ΤΟΥ ΠΡΟΪΟΝΤΟΣ(DELIVERY,TAKE AWAY).\n\n ΣΗΜΕΙΩΣΕΙΣ:ΣΤO ΠΕΔΙΟ 'ΑΡΙΘΜΟΣ', ΠΛΗΚΤΡΟΛΟΓΗΣΤΕ ΜΟΝΟ ΑΡΙΘΜΟΥΣ, ΣΤΟ ΠΕΔΙΟ 'ΑΡΙΘΜΟΣ ΚΑΡΤΑΣ' ΠΛΗΚΤΡΟΛΟΓΗΣΤΕ ΑΚΡΙΒΩΣ 16 ΨΗΦΙΑ, ΣΤΟ ΠΕΔΙΟ 'ΑΡΙΘΜΟΣ ΑΣΦΑΛΕΙΑΣ' ΠΛΗΚΤΡΟΛΟΓΗΣΤΕ ΑΚΡΙΒΩΣ 3 ΑΡΙΘΜΟΥΣ.", "Βοήθεια");
        }
    }
}
