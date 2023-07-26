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

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Stok
{
    public partial class Sil : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");
        OleDbCommand komut = new OleDbCommand();
        public Sil()
        {
            InitializeComponent();
        }
        public void verilerigörüntüle(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        private void miktarsil()
        {
            if (textBox4.Text != "")
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select urun,miktar From Ürünler where barkod=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                OleDbDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    textBox3.Text = dr["miktar"].ToString();
                    textBox2.Text = dr["urun"].ToString();
                }

                if (textBox3.Text == "")
                {
                    textBox3.Text = "0";
                }
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";
                }
                int sayi1 = int.Parse(textBox3.Text);
                int sayi2 = int.Parse(textBox4.Text);
                int sonuc = sayi1 - sayi2;
                textBox5.Text = sonuc.ToString();

                OleDbCommand komut2 = new OleDbCommand("update Ürünler set miktar='" + textBox5.Text + "' where barkod='" + textBox1.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                verilerigörüntüle("Select * From Ürünler");
            }
        }
        private void kilosil()
        {
            if (textBox7.Text != "")
            {
                baglanti.Open();
                OleDbCommand komut3 = new OleDbCommand("Select urun,kilo From Ürünler where barkod=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", textBox1.Text);
                OleDbDataReader dr1 = komut3.ExecuteReader();


                while (dr1.Read())
                {
                    textBox6.Text = dr1["kilo"].ToString();
                    textBox2.Text = dr1["urun"].ToString();
                }

                if (textBox6.Text == "")
                {
                    textBox6.Text = "0";
                }
                if (textBox7.Text == "")
                {
                    textBox7.Text = "0";
                }

                int sayi3 = int.Parse(textBox6.Text);
                int sayi4 = int.Parse(textBox7.Text);
                int sonuc2 = sayi3 - sayi4;
                textBox8.Text = sonuc2.ToString();

                OleDbCommand komut4 = new OleDbCommand("update Ürünler set kilo='" + textBox8.Text + "' where barkod='" + textBox1.Text + "'", baglanti);
                komut4.ExecuteNonQuery();

                verilerigörüntüle("Select * From Ürünler");

            }
        }
            private void miktarsilrapor()
        {
            string tur = "Silme";
            string barkod = textBox1.Text.ToString();
            string urun = textBox2.Text.ToString();
            string miktar = textBox4.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut3 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Miktar,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + miktar + "','" + tur + "','" + tarih + "')", baglanti);
            komut3.ExecuteNonQuery();

            baglanti.Close();
        }
        private void kilosilrapor()
        {
            string tur = "Silme";
            string barkod = textBox1.Text.ToString();
            string urun = textBox2.Text.ToString();
            string kilo = textBox7.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut5 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Kilo,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + kilo + "','" + tur + "','" + tarih + "')", baglanti);
            komut5.ExecuteNonQuery();

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Miktar Sil:
            if (textBox4.Text != "")
            {
                miktarsil();
                //Miktar Sil Rapor:
                miktarsilrapor();
            }
            if (textBox7.Text != "")
            {
                //Kilo Sil:
                kilosil();
                //Kilo Sil Rapor:
                kilosilrapor();
            }  
                      
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
