using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Green,20);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
               // g.DrawLine(Pens.Black, 10, 10, 40, 40);
                g.DrawEllipse(pen, 0, 0, 30, 30);
            }
            /// Назначаем наш Bitmap свойству Image
            pictureBox1.Image = bmp;
        }
    }
}
