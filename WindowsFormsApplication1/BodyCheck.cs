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
        Image defaultImage, newImage;

        
        Bitmap bmp1 = new Bitmap(WindowsFormsApplication1.Properties.Resources.newBodyCheck);
        private Point? _Previous = null;
        Graphics drawingSurface;
        Pen p = new Pen(Color.Black, 2);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);


        public BodyCheck()
        {
            InitializeComponent();


            defaultImage = WindowsFormsApplication1.Properties.Resources.newBodyCheck;

            bodyCheckDate.Format = DateTimePickerFormat.Custom;
            //bodyCheckDate.ShowUpDown = true;

            bodyCheckTime.Format = DateTimePickerFormat.Custom;
            bodyCheckTime.ShowUpDown = true;
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
                using (drawingSurface = Graphics.FromImage(pictureBox1.Image))
                {
                    drawingSurface.DrawLine(p, _Previous.Value, e.Location);
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

        private void default1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
            currentPenColor_pb.BackColor = Color.Black;
        }

        private void red_Click_1(object sender, EventArgs e)
        {
            p.Color = Color.Red;
            currentPenColor_pb.BackColor = Color.Red;
        }

        private void bluePenColor_pb_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
            currentPenColor_pb.BackColor = Color.Blue;
        }

        private void greenPenColor_pb_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
            currentPenColor_pb.BackColor = Color.Green;
        }

        private void penSize_nud_ValueChanged(object sender, EventArgs e)
        {
            int penSize = (int)penSize_nud.Value;
            p.Width = penSize;
        }

        private void BodyCheck_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            newImage = (Image)defaultImage.Clone();
            Graphics g = Graphics.FromImage(newImage);
            pictureBox1.Image = newImage;
            pictureBox1.Invalidate();
        }
    }
}