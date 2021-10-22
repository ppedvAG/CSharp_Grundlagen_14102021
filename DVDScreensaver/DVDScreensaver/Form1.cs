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

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speedX = 3;
        int speedY = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            myButton1.Left += speedX;
            myButton1.Top += speedY;

            if (myButton1.Left + myButton1.Width >= ClientRectangle.Width ||
                myButton1.Left <= 0)
            {
                speedX *= -1;
                MachWas();
            }

            if (myButton1.Top + myButton1.Height >= ClientRectangle.Height ||
                myButton1.Top <= 0)
            {
                speedY *= -1;
                MachWas();
            }
        }

        Random ran = new Random();

        void MachWas()
        {
            //Console.Beep(400, 200);

            BackColor = GetRandomColor();
            myButton1.BackColor = GetRandomColor();
        }

        Color GetRandomColor()
        {
            int r = ran.Next(256);
            int g = ran.Next(256);
            int b = ran.Next(256);

            Color myColor = Color.FromArgb(r, g, b);

            return myColor;
        }

    }
}
