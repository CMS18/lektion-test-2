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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdVisa_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(textBox1_fornamn.Text, textBox2_efternamn.Text, textBox3_personnummer.Text, textbox4_telefon.Text, textBox5_email.Text);
            string fel;
            List<string> saknadeVarde = newStudent.KontrolleraVarden();
            if (saknadeVarde.Count != 0)
            {
                fel = "Du måste fylla in ";
                foreach (string item in saknadeVarde)
                {
                    fel += "\n" + item;
                }


                MessageBox.Show(fel);
            }

            MessageBox.Show("Du har matat in " + newStudent.Fornamn + " " + newStudent.Efternamn + " " + newStudent.Personnummer + " " + newStudent.Email + " " + newStudent.Telefon);
        }

        private void button3_hamtabetyg_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(textBox1_fornamn.Text, textBox2_efternamn.Text, textBox3_personnummer.Text, textbox4_telefon.Text, textBox5_email.Text);
            string[,] kurserBetyg = newStudent.HamtaBetyg();
            listBox1.Items.Add(kurserBetyg[0, 0] + ", " + kurserBetyg[0, 1]);
            listBox1.Items.Add(kurserBetyg[1, 0] + ", " + kurserBetyg[1, 1]);
            listBox1.Items.Add(kurserBetyg[2, 0] + ", " + kurserBetyg[2, 1]);
        }
    }
}
