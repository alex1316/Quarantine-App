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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        int temp_integer;
        int temp_decimal;
        int complete=0;
        byte temp_taken=0;       
        Random r = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = false;
            temp_taken++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp_taken++;
            button1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Θερμομέτρηση...  " + complete + " %";
            complete += 10;
            if (complete > 100)
            {
                timer1.Enabled = false;
                complete = 0;
                temp_integer = r.Next(36, 40);
                temp_decimal = r.Next(0, 10);
                label2.Text = "Η Θερμοκρασία σας: " + temp_integer + "," + temp_decimal + "°C";
                if (temp_taken == 1) {
                    if (temp_integer == 36 && temp_decimal <= 6)
                    {
                        MessageBox.Show("Η ΘΕΡΜΟΚΡΑΣΙΑ ΣΑΣ ΚΥΜΑΙΝΕΤΑΙ ΣΕ ΦΥΣΙΟΛΟΓΙΚΑ ΠΛΑΙΣΙΑ, ΜΠΟΡΕΙΤΕ ΝΑ ΕΙΣΕΛΕΘΕΤΕ.", "Η είσοδος επιτρέπεται");
                        this.Close();

                    }
                    else if ((temp_integer == 36 && temp_decimal > 6) || (temp_integer == 37 && temp_decimal <= 2))
                    {
                        MessageBox.Show("Η ΤΙΜΗ ΤΗΣ ΘΕΡΜΟΚΡΑΣΙΑΣ ΣΑΣ ΕΙΝΑΙ ΑΝHΣΥΧHΤΙΚΗ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤE ΛΙΓΟ ΚΑΙ ΞΑΝΑΜΕΤΡΗΘΕΙΤΕ.", "Πρέπει να θερμομετρηθείτε ξανά");
                        button2.Visible = false;
                    }
                    else if ((temp_integer == 37 && temp_decimal > 2) && temp_integer < 38)
                    {
                        MessageBox.Show("ΛΟΓΩ ΥΨΗΛΗΣ ΘΕΡΜΟΚΡΑΣΙΑΣ, ΔΕΝ ΣΑΣ ΕΠΙΤΡΕΠΕΤAI Η ΕΙΣΟΔΟΣ. ΣΑΣ ΠΡΟΤΕΙΝΟΥΜΕ ΠΡΟΣΟΧΗ.", "Η είσοδος δεν επιτρέπεται");
                        this.Close();
                    }
                    else if (temp_integer >= 38)
                    {
                        MessageBox.Show("ΛΟΓΩ ΥΨΗΛΗΣ ΘΕΡΜΟΚΡΑΣΙΑΣ, ΔΕΝ ΣΑΣ ΕΠΙΤΡΕΠΕΤAI Η ΕΙΣΟΔΟΣ. ΣΑΣ ΠΡΟΤΕΙΝΟΥΜΕ ΝΑ ΠΑΤΕ ΣΤΟ ΠΛΗΣΙEΣΤΕΡΟ ΔΙΑΓΝΩΣΤΙΚΟ ΚΕΝΤΡΟ ΤΗΣ ΠΕΡΙΟΧΗΣ ΣΑΣ ΓΙΑ ΤΕΣΤ COVID-19.", "Η είσοδος δεν επιτρέπεται");
                        Form19 hospitals = new Form19();
                        hospitals.Show();
                        this.Hide();
                    }
                }
                if (temp_taken == 2)
                {
                    if (temp_integer == 36 && temp_decimal <= 6)
                    {
                        MessageBox.Show("Η ΘΕΡΜΟΚΡΑΣΙΑ ΣΑΣ ΚΥΜΑΙΝΕΤΑΙ ΣΕ ΦΥΣΙΟΛΟΓΙΚΑ ΠΛΑΙΣΙΑ, ΜΠΟΡΕΙΤΕ ΝΑ ΕΙΣΕΛΕΘΕΤΕ.", "Η είσοδος επιτρέπεται");
                        this.Close();

                    }
                    else if (((temp_integer == 36 && temp_decimal > 6) || (temp_integer == 37 && temp_decimal >= 2)) && temp_integer < 38)
                    {
                        MessageBox.Show("ΛΟΓΩ ΥΨΗΛΗΣ ΘΕΡΜΟΚΡΑΣΙΑΣ, ΔΕΝ ΣΑΣ ΕΠΙΤΡΕΠΕΤAI Η ΕΙΣΟΔΟΣ. ΣΑΣ ΠΡΟΤΕΙΝΟΥΜΕ ΠΡΟΣΟΧΗ.", "Η είσοδος δεν επιτρέπεται");
                        this.Close();
                    }
                    else if (temp_integer >= 38)
                    {
                        MessageBox.Show("ΛΟΓΩ ΥΨΗΛΗΣ ΘΕΡΜΟΚΡΑΣΙΑΣ, ΔΕΝ ΣΑΣ ΕΠΙΤΡΕΠΕΤAI Η ΕΙΣΟΔΟΣ. ΣΑΣ ΠΡΟΤΕΙΝΟΥΜΕ ΝΑ ΠΑΤΕ ΣΤΟ ΠΛΗΣΙEΣΤΕΡΟ ΔΙΑΓΝΩΣΤΙΚΟ ΚΕΝΤΡΟ ΤΗΣ ΠΕΡΙΟΧΗΣ ΣΑΣ ΓΙΑ ΤΕΣΤ COVID-19.", "Η είσοδος δεν επιτρέπεται");
                        Form19 hospitals = new Form19();
                        hospitals.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
