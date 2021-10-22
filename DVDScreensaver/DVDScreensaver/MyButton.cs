using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DVDScreensaver
{
    class MyButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //base.OnPaint(pevent);
            //pevent.Graphics.FillRectangle(Brushes.DarkSalmon, ClientRectangle);
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            LinearGradientBrush verlauf = new LinearGradientBrush(ClientRectangle, Color.DeepSkyBlue, Color.LightCyan, 90f);
            pevent.Graphics.FillEllipse(verlauf, ClientRectangle);

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            pevent.Graphics.DrawString(Text, SystemFonts.CaptionFont, Brushes.Black, ClientRectangle, sf);

            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                pevent.Graphics.DrawEllipse(new Pen(Color.DarkMagenta, 6f), ClientRectangle);
            }
        }
    }
}
