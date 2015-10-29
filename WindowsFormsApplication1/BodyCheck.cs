using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BodyCheck : Form
    {
        Bitmap bmp1 = new Bitmap(WindowsFormsApplication1.Properties.Resources._174C6A44052F3636FE3697012A1BEF80E0CA16F00D051B2597_pimgpsh_fullsize_distr);
        private Point? _Previous = null;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;
        public BodyCheck()
        {
            InitializeComponent();
        }

        private void red_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _Previous = e.Location;
            pictureBox1_MouseMove(sender, e);

            /*sp = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;*/
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (_Previous != null)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = bmp1;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(Pens.Black, _Previous.Value, e.Location);
                }
                pictureBox1.Invalidate();
                _Previous = e.Location;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            _Previous = null;

            // k = 0;
        }

    }
}