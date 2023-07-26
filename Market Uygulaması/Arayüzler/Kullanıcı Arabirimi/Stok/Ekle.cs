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

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi
{
    public partial class Form4 : Form
    {
        public Form4()
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
        private void miktarrapor()
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("Select urun from Ürünler where barkod=('" + textBox1.Text.ToString() + "')", baglanti);
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr["urun"].ToString();
            }
            string tur = "Değiştirme";
            string barkod = textBox1.Text.ToString();
            string urun = textBox2.Text.ToString();
            string miktar = textBox3.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut2 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Miktar,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + miktar + "','" + tur + "','" + tarih + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
        private void kilorapor()
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("Select urun from Ürünler where barkod=('" + textBox1.Text.ToString() + "')", baglanti);
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr["urun"].ToString();
            }
            string tur = "Değiştirme";
            string barkod = textBox1.Text.ToString();
            string urun = textBox2.Text.ToString();
            string kilo = textBox4.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut2 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Kilo,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + kilo + "','" + tur + "','" + tarih + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void miktardegis()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Ürünler set miktar='" + textBox3.Text + "'where barkod='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void kilodegis()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Ürünler set kilo='" + textBox4.Text + "'where barkod='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void miktarraporekle()
        {
            string tur = "Ekleme";
            string barkod = textBox5.Text.ToString();
            string urun = textBox8.Text.ToString();
            string miktar = textBox9.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut3 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Miktar,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + miktar + "','" + tur + "','" + tarih + "')", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
        private void kiloraporekle()
        {
            string tur = "Ekleme";
            string barkod = textBox5.Text.ToString();
            string urun = textBox8.Text.ToString();
            string kilo = textBox11.Text.ToString();
            string tarih = dateTimePicker1.Value.ToString();
            OleDbCommand komut5 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Kilo,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + kilo + "','" + tur + "','" + tarih + "')", baglanti);
            komut5.ExecuteNonQuery();
            baglanti.Close();
        }
        private void miktarekle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select urun,miktar From Ürünler where barkod=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox5.Text);
            OleDbDataReader dr = komut.ExecuteReader();


            while (dr.Read())
            {
                textBox7.Text = dr["miktar"].ToString();
                textBox8.Text = dr["urun"].ToString();
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            int sayi1 = int.Parse(textBox7.Text);
            int sayi2 = int.Parse(textBox9.Text);
            int sonuc = sayi1 + sayi2;
            textBox10.Text = sonuc.ToString();

            OleDbCommand komut2 = new OleDbCommand("update Ürünler set miktar='" + textBox10.Text + "' where barkod='" + textBox5.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            verilerigörüntüle("Select * From Ürünler");
        }
        private void kiloekle()
        {
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("Select urun,kilo From Ürünler where barkod=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBox5.Text);
            OleDbDataReader dr1 = komut3.ExecuteReader();


            while (dr1.Read())
            {
                textBox6.Text = dr1["kilo"].ToString();
                textBox8.Text = dr1["urun"].ToString();
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }

            int sayi3 = int.Parse(textBox6.Text);
            int sayi4 = int.Parse(textBox11.Text);
            int sonuc2 = sayi3 + sayi4;
            textBox12.Text = sonuc2.ToString();

            OleDbCommand komut4 = new OleDbCommand("update Ürünler set kilo='" + textBox12.Text + "' where barkod='" + textBox5.Text + "'", baglanti);
            komut4.ExecuteNonQuery();
            verilerigörüntüle("Select * From Ürünler");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Barkod Kısmı Boş Bırakılamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tb1;
                string tb2;

                tb1 = textBox3.Text;
                tb2 = textBox4.Text;
                if (tb1 != "")
                {
                    miktardegis();
                    miktarrapor();
                }
                if (tb2 != "")
                {
                    kilodegis();
                    kilorapor();
                }
                verilerigörüntüle("Select * From Ürünler");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }
        //
        //
        //
        //Ürün Ekleme Kısmı:

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Barkod Kısmı Boş Bırakılamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox9.Text != "")
                {
                    //Miktar Ekleme:
                    miktarekle();
                    //Miktar Rapor Ekleme:
                    miktarraporekle();
                }
                if (textBox11.Text != "")
                {
                    //Kilo Ekleme:
                    kiloekle();
                    //Kilo Rapor Ekleme:
                    kiloraporekle();
                }
            }
        }
    }
}
