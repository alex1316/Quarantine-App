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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσήρθατε στην εφαρμογή έξυπνης καραντίνας! Οι λειτουργίες της εφαρμογής είναι οι εξής:\n\n1. Οργάνωση πλάνου μετακινήσεων: Προγραμματισμός αποστολής μηνυμάτων στο 13033 για τις ημερήσιες μετακινήσεις σας.\n\n2. Έλεγχος φώτων και συσκευών: Απομακρυσμένος έλεγχος των φώτων και των ηλεκτρικών συσκευών σε κάθε δωμάτιο του σπιτιού, ώστε να μην ενοχλούνται τα υπόλοιπα άτομα μέσα στο σπίτι που πραγματοποιούν τηλεδιασκέψεις.\n\n3. Έξυπνο θερμόμετρο εξώπορτας: Εποπτεία του έξυπνου ηλεκτρονικού θερμομέτρου που βρίσκεται στην εξώπορτα, δίπλα από το κουδούνι της πόρτας.\n\n4. Απομακρυσμένη εποπτεία ηλικιωμένων: Απομακρυσμένη εποπτεία κάποιου ηλικιωμένου συγγενή. Το ηλικιωμένο άτομο δύναται να επικοινωνήσει με γιατρό, ψυχολόγο ή τον δήμο μέσω της εφαρμογής, και σε περίπτωση ανάγκης, η εφαρμογή ειδοποιεί αυτόματα συγγενείς και γιατρούς.\n\n5. Online παραγγελία καφέ: Παραγγελία καφέ μέσω διαδικτύου.\n\nΓια να χρησιμοποιήσετε κάποια από τις δυνατότητες της εφαρμογής, κάντε κλικ στην αντίστοιχη εικόνα στο κεντρικό μενού της εφαρμογής.\n\nΓια κλείσιμο της εφαρμογής, κάντε κλικ στο κουμπί 'Κλείσιμο'.", "Βοήθεια");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 quar_plan = new Form2();
            quar_plan.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 smart_home = new Form3();
            smart_home.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 thermometer = new Form4();
            thermometer.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 elderly_watch = new Form5();
            elderly_watch.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 online_order = new Form6();
            online_order.Show();
        }
    }
}
