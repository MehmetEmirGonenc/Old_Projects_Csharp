using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Ürünler
{
    public partial class Uekle : Form
    {
        public Uekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");
        OleDbCommand komut = new OleDbCommand();
        public void verilerigörüntüle(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void urundegis()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Ürünler set urun='" + textBox2.Text + "'where barkod='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void fiyatdegis()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Ürünler set fiyat='" + textBox3.Text + "'where barkod='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            //baglanti.Open();
            //komut.Connection = baglanti;
            //komut.CommandText = "update Ürünler set urun='" + textBox2.Text + "',fiyat='" + textBox3.Text + "',miktar='" + textBox4.Text + "'where barkod='" + textBox1.Text + "'";
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //verilerigörüntüle();
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Ürünler (barkod,urun,fiyat) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigörüntüle("Select * From Ürünler where barkod");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch
            {
                MessageBox.Show("Eklemeye Çalıştığınız Ürün Zaten Eklenmiş Durumda!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Close();
            }
        }

        private void Uekle_Load(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Barkod Kısmı Boş Bırakılamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tb2;
                string tb3;
                tb2 = textBox2.Text;
                tb3 = textBox3.Text;
                if (tb2 != "")
                {
                    urundegis();
                }
                if (tb3 != "")
                {
                    fiyatdegis();
                }
                verilerigörüntüle("Select * From Ürünler");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
