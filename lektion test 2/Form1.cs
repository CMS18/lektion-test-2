using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lektion_test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VisaClick(object sender, EventArgs e)
        {
            kurs MyKurs = new kurs();
            MyKurs.Namn = textBox1.Text;
            MyKurs.Poang = int.Parse(textBox2.Text);
            MyKurs.StartDatum = StartDatumLabel.Text;
            MyKurs.SlutDatum = SlutDatumLabel.Text;
            MessageBox.Show("Kursnamn: " + MyKurs.Namn + "\nAntal Poäng: " + MyKurs.Poang + "\nStartdatum: " + MyKurs.StartDatum + "\nSlutdatum: " + MyKurs.SlutDatum + " ");
    
        }

        private void Berakna_Click(object sender, EventArgs e)
        {
            kurs MyKurs = new kurs();
           double AntalDagar = MyKurs.BeraknaAntalKursDagar(DateTime.Parse(StartDatumLabel.Text), DateTime.Parse(SlutDatumLabel.Text));
            MessageBox.Show(AntalDagar.ToString() + " Dagar");
        }
    }
}
