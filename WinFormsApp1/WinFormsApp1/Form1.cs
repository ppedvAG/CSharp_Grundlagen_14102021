using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

       
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();

            specClient client = new specClient("https://libretranslate.com/translate", http);
            var tststs = await client.TranslateAsync("Welt", "de", "en", Format.Text, "");

        }
    }
}
