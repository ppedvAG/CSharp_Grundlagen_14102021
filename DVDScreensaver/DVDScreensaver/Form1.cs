using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            button1.Left += speedX;
            button1.Top += speedY;

            if (button1.Left + button1.Width >= ClientRectangle.Width ||
                button1.Left <= 0)
            {
                speedX *= -1;
                MachWas();
            }

            if (button1.Top + button1.Height >= ClientRectangle.Height ||
                button1.Top <= 0)
            {
                speedY *= -1;
                MachWas();
            }
        }

        void MachWas()
        {
            Console.Beep(400, 600);

        }

    }
}
