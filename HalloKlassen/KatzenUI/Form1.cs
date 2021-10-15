using Bogus;
using HalloKlassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatzenUI
{
    public partial class Form1 : Form
    {
        BindingList<Katze> katzenListe = new BindingList<Katze>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = katzenListe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Katze katze = new Katze();
            katze.Name = "Henry";
            katze.Gewicht = 6.2;
            katze.Farbe = "black tabby";
            katze.Rasse = "maine coon";
            katze.GebDatum = new DateTime(2002, 10, 16);
            katze.Geschlecht = Geschlecht.Männlich;

            katzenListe.Add(katze);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faker<Katze> faker = new Faker<Katze>("de")
                                .RuleFor(x => x.Name, (f, u) => f.Name.FirstName())
                                .RuleFor(x => x.Gewicht, (f, u) => f.Random.Double(1, 7))
                                .RuleFor(x => x.Farbe, (f, u) => f.Commerce.Color())
                                .RuleFor(x => x.Rasse, (f, u) => $"{f.Commerce.ProductAdjective()} {f.Commerce.Product()}")
                                .RuleFor(x => x.GebDatum, (f, u) => f.Date.Recent())
                                .RuleFor(x => x.Geschlecht, (f, u) => f.PickRandom<Geschlecht>());

            Katze bogusKatze = faker.Generate();

            katzenListe.Add(bogusKatze);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("Hallo Welt");
                sw.Close();
            }
        }
    }
}
