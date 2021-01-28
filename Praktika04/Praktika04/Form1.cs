using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika04
{
    public partial class Form1 : Form
    {
        int radius;
        int center_x, center_y;
        Color color;
        Graphics grap;

        private void Form1_Resize(object sender, EventArgs e)
        {
            center_x = picCircle.Width / 2 - radius;
            center_y = picCircle.Height / 2 - radius;
            PaintCircle();
        }

        private void PaintCircle()
        {
            picCircle.Image = new Bitmap(picCircle.Width, picCircle.Height);
            grap = Graphics.FromImage(picCircle.Image);
            grap.Clear(Color.White);
            SolidBrush brush = new SolidBrush(color);
            grap.FillEllipse(brush, center_x, center_y, radius * 2, radius * 2);
            picCircle.Refresh();
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
                PaintCircle();
            }
        }

        private void menuRadius_Click(object sender, EventArgs e)
        {
            SizeDialog dialog = new SizeDialog(radius);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radius = dialog.Value;
                center_x = picCircle.Width / 2 - radius;
                center_y = picCircle.Height / 2 - radius;
                PaintCircle();
            }
        }

        public Form1()
        {
            InitializeComponent();
           
            radius = (int)((Width < Height ? Width : Height) / 2 * 0.8);
            color = Color.Black;

            Form1_Resize(this, null);
        }
    }
}
