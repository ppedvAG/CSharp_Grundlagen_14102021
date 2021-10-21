using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

            string cleaned = CleanJsonString(json);

            listBox1.Items.Insert(0, cleaned);

            button1.Enabled = true;
        }

        private string CleanJsonString(string jsonString)
        {
            jsonString = Encoding.UTF8.GetString(Encoding.Convert(Encoding.UTF8, Encoding.Default, Encoding.Default.GetBytes(jsonString)));
            jsonString = jsonString.Replace("[", "");
            jsonString = jsonString.Replace("]", "");
            jsonString = jsonString.Replace("{", "");
            jsonString = jsonString.Replace("}", "");
            jsonString = jsonString.Replace("\"fact\":", "");
            jsonString = jsonString.Replace("\"", "");
            jsonString = jsonString.Replace("\\u2019", "'");
            jsonString = jsonString.Trim();
            return jsonString;
        }


        int hundeCounter = 0;

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            hundeCounter++;
            try
            {
                if (hundeCounter > 5)
                    throw new HundeOverloadException() { HundeCounter = hundeCounter };

                //mit ohne Proxy
                HttpClient http = new HttpClient();
                string testBildUrl = "https://random.dog/e1311960-ea27-49a2-9789-d854f4500fea.gif";

                string json = await http.GetStringAsync("https://random.dog/woof.json"); //json  text laden

                HundeBild hundeBild = JsonSerializer.Deserialize<HundeBild>(json); //json text in HundeBild Klassen instanz serialisieren

                label1.Text = $"{hundeBild.fileSizeBytes} bytes"; //größe des Bildes aus der Klasse im Label anzeigen 
                Image img = Image.FromStream(await http.GetStreamAsync(hundeBild.url)); //Bild aus JSON/HundeBild URL runterladen
                pictureBox1.Image = img; // bild anzeigen

            }
            catch (HundeOverloadException ex)
            {
                MessageBox.Show($"Du hast schon genug Hunde gesehen, es waren ja immerhin schon {ex.HundeCounter}");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler beim download: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Fehler beim anzeigen des Bildes: {ex.Message}: {ex.ParamName}");
            }
            catch (SystemException ex)
            {
                MessageBox.Show($"Fehler beim anzeigen des Bildes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }

            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                WerfeEinenFehler();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Da klappt etwas nicht: {ex.Message}");
            }
        }

        /// <summary>
        /// Wirft einen Fehler
        /// </summary>
        /// <remarks>
        /// Diese Methode dient als Beispiel zum werfen von Exception
        /// </remarks>
        /// <exception cref="InvalidOperationException"/>
        private void WerfeEinenFehler()
        {
            throw new InvalidOperationException("Das geht so nicht!");
        }
    }
}
