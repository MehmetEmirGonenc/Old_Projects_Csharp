using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Ayarlar
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            textBox1.Text = Barkod_Uygulaması.Properties.Settings.Default.marketadi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                DialogResult cevap = new DialogResult();
                cevap = MessageBox.Show("İşletmenizin İsmini '" + textBox1.Text + "' Yapmak İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == cevap)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.marketadi = textBox1.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("İşletmenizin İsmi Başarı İle Değiştirildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
            else
            {
                MessageBox.Show("'İşletme Adı' Kısmı Boş Bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
