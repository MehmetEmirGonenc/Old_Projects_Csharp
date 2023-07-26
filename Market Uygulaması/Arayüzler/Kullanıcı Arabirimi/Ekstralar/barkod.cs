using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Ekstralar
{
    public partial class barkodolustur : Form
    {
        public barkodolustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = brc.Draw(textBox1.Text, 400);
        }
    }
}
