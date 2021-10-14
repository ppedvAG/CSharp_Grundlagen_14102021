using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalc
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textDerTextBox1 = textBox1.Text;
            string textDerTextBox2 = textBox2.Text;

            if (!int.TryParse(textDerTextBox1, out int zahl1))
            {
                MessageBox.Show("Zahl 1 konnte nicht eingelesen werden");
                return;
            }

            int zahl2;
            if (!int.TryParse(textDerTextBox2, out zahl2))
            {
                MessageBox.Show("Zahl 2 konnte nicht eingelesen werden");
                return;
            }

            int ergebnis = zahl1 + zahl2;

            label1.Text = ergebnis.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal result = numericUpDown1.Value + numericUpDown2.Value;
            label3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool statusVonCheckBox1 = checkBox1.Checked;
            bool statusVonCheckBox2 = checkBox2.Checked;

            bool result = statusVonCheckBox1 && statusVonCheckBox2;

            boolAndLabel.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool result = checkBox1.Checked || checkBox2.Checked;

            boolOrLabel.Text = result.ToString();

        }

        int zähler = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            //zähler = zähler + 1;
            zähler += 2;
            //zähler++;

            inkLabel.Text = zähler.ToString();
        }
    }
}
