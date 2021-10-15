using Bogus;
using HalloKlassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        BindingList<Tier> katzenListe = new BindingList<Tier>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = katzenListe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tier katze = new Tier("Fred");
            //katze.Name = "Henry";
            katze.Gewicht = 6.2;
            katze.Farbe = "black tabby";
            katze.Rasse = "maine coon";
            katze.GebDatum = new DateTime(2002, 10, 16);
            katze.Geschlecht = Geschlecht.Männlich;

            katzenListe.Add(katze);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faker<Tier> faker = new Faker<Tier>("de")
                                .RuleFor(x => x.Name, (f, u) => f.Name.FirstName())
                                .RuleFor(x => x.Gewicht, (f, u) => f.Random.Double(1, 7))
                                .RuleFor(x => x.Farbe, (f, u) => f.Commerce.Color())
                                .RuleFor(x => x.Rasse, (f, u) => $"{f.Commerce.ProductAdjective()} {f.Commerce.Product()}")
                                .RuleFor(x => x.GebDatum, (f, u) => f.Date.Recent())
                                .RuleFor(x => x.Geschlecht, (f, u) => f.PickRandom<Geschlecht>());

            Tier bogusKatze = faker.Generate();

            katzenListe.Add(bogusKatze);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                string trenn = "|";
                foreach (Tier katze in katzenListe)
                {
                    sw.Write(katze.Name);
                    sw.Write(trenn);
                    sw.Write(katze.GebDatum);
                    sw.Write(trenn);
                    sw.Write(katze.Farbe);
                    sw.Write(trenn);
                    sw.Write(katze.Rasse);
                    sw.Write(trenn);
                    sw.Write(katze.Gewicht);
                    sw.Write(trenn);
                    sw.Write(katze.Geschlecht);
                    sw.Write(trenn);

                    sw.WriteLine();
                }

                sw.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                katzenListe.Clear(); // UI leeren
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (!sr.EndOfStream) //lese solange nicht das Ende der Datei erreicht ist
                {
                    string line = sr.ReadLine(); //eine Zeile lesen
                    Debug.WriteLine(line); //zum testen die Zeile im Outputfenster von Visual Studio

                    string[] chunks = line.Split('|'); //die zeile in einzelne häppchen trennen

                    Tier katze = new Tier(); // neue Katze erstellen 
                    katze.Name = chunks[0]; //die jeweiligen werden zuweise 
                    katze.GebDatum = DateTime.Parse(chunks[1]); // oder parsen
                    katze.Farbe = chunks[2];
                    katze.Rasse = chunks[3];
                    katze.Gewicht = double.Parse(chunks[4]);
                    katze.Geschlecht = Enum.Parse<Geschlecht>(chunks[5]);

                    katzenListe.Add(katze); //der Liste im UI hinzufügen
                }
            }
        }
    }
}
