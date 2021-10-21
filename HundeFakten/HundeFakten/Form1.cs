using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace HundeFakten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            string url = "https://dog-facts-api.herokuapp.com/api/v1/resources/dogs?number=1&index=1";

            //mit Proxy
            //var handler = new HttpClientHandler();
            //handler.DefaultProxyCredentials = CredentialCache.DefaultCredentials;
            //HttpClient.DefaultProxy = new WebProxy("http://myFFFProxy:80", true);
            //HttpClient http = new HttpClient(handler);

            //ohne Proxy
            HttpClient http = new HttpClient();

            http.Timeout = TimeSpan.FromSeconds(5); //damit der fehler schneller kommt 

            string json = await http.GetStringAsync(url);

            listBox1.Items.Insert(0, json);

            button1.Enabled = true;
        }
    }
}
