using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace graficador3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        unitario3D este = new unitario3D();
        private void button1_Click(object sender, EventArgs e)
        {
            //este.dibujarEjes3D(this.pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //este.dibujarLinea3D(this.pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            este.dibujarEjes(this.pictureBox1);
            string directorio1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\grafico_cartesiano.png";
            //Bitmap bmp = new Bitmap();
            var mm = (Bitmap)this.pictureBox1.Image.Clone();
            mm.Save(directorio1, ImageFormat.Png);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //grafico.DrawString("P(x:" + xi + ",y:" + yi + ",z:" + zi + ")", letra, rrelleno, puntoini.xr, puntoini.yr);
        }
    }
}
