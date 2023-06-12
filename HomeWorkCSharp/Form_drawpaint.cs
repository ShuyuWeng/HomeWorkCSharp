using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_homepage
{
    public partial class Form_drawpaint : Form
    {
        public Form_drawpaint()
        {
            InitializeComponent();
            drawing = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            Graphics.FromImage(drawing).Clear(Color.White);
            this.Cursor = Cursors.Cross;
        }
        bool draw = false;

        int pX = -1;
        int pY = -1;

        Bitmap drawing;
        Pen pen = new Pen(Color.Black, 1);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics panel = Graphics.FromImage(drawing);
                

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.Round;

                panel.DrawLine(pen, pX, pY, e.X, e.Y);

                panel1.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
            }

            pX = e.X;
            pY = e.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            pX = e.X;
            pY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(drawing, new Point(0, 0));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label_cursorsize.Text =  this.trackBar1.Value.ToString();
            pen.Width = this.trackBar1.Value;
        }

        private void button_color_Click(object sender, EventArgs e)
        {

        }

        private void button_color_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.picturebox_nowcolor.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }
    }
}
