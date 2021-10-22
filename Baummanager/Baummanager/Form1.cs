
using Baummanager.Data;
using Baummanager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Baummanager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ladenButton_Click(object sender, EventArgs e)
        {
            if (demoRadioButton.Checked)
            {
                List<Baum> liste = new List<Baum>();
                liste.Add(new Baum() { Id = 1, Art = "Eiche", Gattung = Gattung.Laub, MaxAlter = 1000, MaxSize = 35 });
                liste.Add(new Baum() { Id = 2, Art = "Buche", Gattung = Gattung.Laub, MaxAlter = 500, MaxSize = 40 });
                liste.Add(new Baum() { Id = 3, Art = "Tanne", Gattung = Gattung.Nadel, MaxAlter = 600, MaxSize = 90 });

                baumDataGridView.DataSource = liste;
                //dataGridView1.DataSource = liste;
            }
            else
            {
                baumDataGridView.DataSource = datamanager.GetBaums().ToList();
            }
        }

        private Datamanager datamanager;

        private void jsonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (jsonRadioButton.Checked)
            {
                datamanager = new Datamanager(new Data.DataProviders.JsonData(), "baum.json");
            }
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            if (datamanager != null)
            {
                datamanager.SaveAll(baumDataGridView.DataSource as IEnumerable<Baum>);
                MessageBox.Show("Speichern erfolgreich");
            }
            else if (datamanager == null)
            {
                MessageBox.Show("Bitte Datenquelle festlegen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (excelRadioButton.Checked)
            {
                datamanager = new Datamanager(new Data.DataProviders.ExcelData(), "bäume.xlsx");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<Baum> baums = (IEnumerable<Baum>)baumDataGridView.DataSource;

            //linq query expression
            var query = from b in baums
                        where b.MaxAlter > 100
                        orderby b.MaxSize descending
                        select b;

            baumDataGridView.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<Baum> baums = (IEnumerable<Baum>)baumDataGridView.DataSource;

            baumDataGridView.DataSource = baums.Where(b => b.MaxAlter > 100) //linq lambda
                                               .OrderByDescending(x => x.MaxSize)
                                               .Take(100)
                                               .ToList();
        }
    }
}
