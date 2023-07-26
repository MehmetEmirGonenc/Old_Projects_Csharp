using Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi;
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
using Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Anamenu.Ürün_Seç;
using Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Stok;
using Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Ürünler;
using Barkod_Uygulaması.Arayüzler;
using Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Ekstralar;

namespace Barkod_Uygulaması
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public static int kontrolanahtarı =0;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");

        private void verilerigoruntule()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select barkod,urun,fiyat,miktar From Ürünler where barkod=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToInt32(dr[3]) >= 1)
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr[0].ToString();
                    ekle.SubItems.Add(dr[1].ToString());
                    ekle.SubItems.Add(dr[2].ToString());
                    ekle.SubItems.Add(1.ToString());
                    //ekle.SubItems.Add((dr[3].ToString()));
                    //ekle.SubItems.Add((dr[4].ToString()));
                    listView1.Items.Add(ekle);
                }
                else
                {
                    MessageBox.Show("Bu Ürün Stokta Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            baglanti.Close();
            textBox1.Clear();
        }

        private void toplam()
        {
            double toplam = 0;

            double[] topla = new double[listView1.Items.Count]; // sonuç ondalıklı değer çıkabilir, işimizi sağlama alabilmek için double kullandık
            double[] carpım = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++) //Listviewdeki tüm değerleri alabilmek için for kullandık
            {

                topla[i] = Convert.ToDouble(listView1.Items[i].SubItems[2].Text.ToString());// burada dikkat edilmesi gereken, SubItems değeri 2 kolon olduğu için 0. kolon ürünün adı 1. kolon ise fiyatı göstermekte

                carpım[i] = Convert.ToDouble(listView1.Items[i].SubItems[3].Text.ToString());
                toplam = toplam + (topla[i] * carpım[i]);

            }

            label2.Text = Convert.ToString(toplam);

        }
        private void rapor()
        {
            int x = 0;
            int z = 1;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                string a = listView1.Items[x].Text.ToString();
                string a1 = listView1.Items[x].SubItems[1].Text.ToString();
                string a2 = listView1.Items[x].SubItems[2].Text.ToString();
                int a3 = Convert.ToInt32(listView1.Items[x].SubItems[3].Text);
                //string a4 = listView1.Items[0].SubItems[4].Text.ToString();
                //,'" + a3.ToString() + "','" + a4.ToString() + "'
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Insert Into Rapor (Barkod,Urun,Fiyat,Miktar,tarih) values ('" + a + "','" + a1 + "','" + a2 + "','" + a3 + "','" + dateTimePicker1.Value.ToString() + "')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listView1.Items[x].Text = "";
                listView1.Items[x].SubItems[z].Text = null;
                z++;
                listView1.Items[x].SubItems[z].Text = null;
                z++;
                listView1.Items[x].SubItems[z].Text = null;
                z = 1;
                x++;
            }

        }
        private void aktaricikontrol()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == Secim.aktarici1)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Select miktar From Ürünler where barkod=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", Secim.aktarici1);
                    OleDbDataReader dr = komut.ExecuteReader();

                    while (dr.Read())
                    {
                        textBox2.Text = dr[0].ToString();
                    }
                    baglanti.Close();
                    int stok = Convert.ToInt32(textBox2.Text);
                    int sayi = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                    //if (listView1.SelectedItems.Count == 1)
                    sayi++;
                    if (stok >= sayi)
                    {
                        listView1.Items[i].SubItems[3].Text = sayi.ToString();
                        kontrolanahtarı = 1;
                    }
                    else
                    {
                        MessageBox.Show("Bu Üründen Daha Fazla Ekleyemessiniz Çünkü Stokta Daha Fazla Ürün Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    textBox1.Text = "";
                }
            }
        }
        private void kontrol()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("Select miktar From Ürünler where barkod=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);
                    OleDbDataReader dr = komut.ExecuteReader();

                    while (dr.Read())
                    {
                        textBox2.Text = dr[0].ToString();
                    }
                    baglanti.Close();
                    int stok = Convert.ToInt32(textBox2.Text);
                    int sayi = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                    //if (listView1.SelectedItems.Count == 1)
                    sayi++;
                    if (stok >= sayi)
                    {
                        listView1.Items[i].SubItems[3].Text = sayi.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Bu Üründen Daha Fazla Ekleyemessiniz Çünkü Stokta Daha Fazla Ürün Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    textBox1.Text = "";
                }
            }
        }
        private void verilerisil()
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == secim)
            {
                for (int i = listView1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
                }
                verilerigoruntule();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form4 yenisayfa = new Form4();
            this.Hide();
            yenisayfa.ShowDialog();
            this.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                Application.Exit();
            }
            finally
            {
                baglanti.Close();
            }
            if (Barkod_Uygulaması.Properties.Settings.Default.ayrac == 1)
            {
                MessageBox.Show("Başarı İle Yönetici Girişi Yapıldı!");
            }
            else
            {
                if (Barkod_Uygulaması.Properties.Settings.Default.ayrac == 0)
                {
                    MessageBox.Show("Başarı İle Personel Girişi Yapıldı!");
                }
            }
            comboBox1.SelectedItem = "₺";
            label2.Text = "0,00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Barkod_Uygulaması.Properties.Settings.Default.ayrac == 1)
            {
                Form3 yenisayfa = new Form3();
                this.Hide();
                yenisayfa.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ayarlar'a Girmek İçin Yönetici Olmalısınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 yenisayfa = new Form4();
            yenisayfa.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrol();
            verilerigoruntule();
            toplam();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verilerisil();
            toplam();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Satışı İptal Etmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == cevap)
            {
                listView1.Items.Clear();
                toplam();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secim yenisayfa = new Secim();
            yenisayfa.ShowDialog();
            if (Secim.aktarici1 != "" && Secim.aktarici2 != "" && Secim.aktarici3 != "")
            {
                aktaricikontrol();
                if (kontrolanahtarı == 0)
                {
                    if (Convert.ToInt32(Secim.aktarici4) >= 1)
                    {
                        string a1 = Secim.aktarici1.ToString();
                        string a2 = Secim.aktarici2.ToString();
                        string a3 = Secim.aktarici3.ToString();
                        //string a4 = Secim.aktarici4.ToString();
                        //string a5 = Secim.aktarici5.ToString();

                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = (a1);
                        ekle.SubItems.Add(a2);
                        ekle.SubItems.Add(a3);
                        ekle.SubItems.Add(1.ToString());
                        //ekle.SubItems.Add(a4);
                        //ekle.SubItems.Add(a5);

                        listView1.Items.Add(ekle);
                        toplam();
                    }
                    else
                    {
                        MessageBox.Show("Bu Ürün Stokta Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                kontrolanahtarı = 0;
                Secim.aktarici1 = "";
                Secim.aktarici2 = "";
                Secim.aktarici3 = "";
            }
            else
            {
                MessageBox.Show("İlk Önce Ürün Seç Kısmından Bir Ürün Seçmeniz Gerekmekte.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Secim.aktarici1 != "" && Secim.aktarici2 != "" && Secim.aktarici3 != "")
            {
                aktaricikontrol();
                if (kontrolanahtarı == 0)
                {
                    if (Convert.ToInt32(Secim.aktarici4) >= 1)
                    {
                        string a1 = Secim.aktarici1.ToString();
                        string a2 = Secim.aktarici2.ToString();
                        string a3 = Secim.aktarici3.ToString();
                        //string a4 = Secim.aktarici4.ToString();
                        //string a5 = Secim.aktarici5.ToString();

                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = (a1);
                        ekle.SubItems.Add(a2);
                        ekle.SubItems.Add(a3);
                        ekle.SubItems.Add(1.ToString());
                        //ekle.SubItems.Add(a4);
                        //ekle.SubItems.Add(a5);

                        listView1.Items.Add(ekle);
                        toplam();
                    }
                    else
                    {
                        MessageBox.Show("Bu Ürün Stokta Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                kontrolanahtarı = 0;
                Secim.aktarici1 = "";
                Secim.aktarici2 = "";
                Secim.aktarici3 = "";
            }
            else
            {
                MessageBox.Show("İlk Önce Ürün Seç Kısmından Bir Ürün Seçmeniz Gerekmekte.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void hEsapAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Barkod_Uygulaması.Properties.Settings.Default.ayrac == 1)
            {
                Form3 yenisayfa = new Form3();
                this.Hide();
                yenisayfa.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ayarlar'a Girmek İçin Yönetici Olmalısınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stokSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sil yenisayfa = new Sil();
            yenisayfa.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünEklmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uekle yenisayfa = new Uekle();
            yenisayfa.ShowDialog();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usil yenisayfa = new Usil();
            yenisayfa.ShowDialog();
        }

        private void stokBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok yenisayfa = new Stok();
            yenisayfa.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            satis();
            printPreviewDialog1.ShowDialog();
            rapor();
            listView1.Items.Clear();
            label2.Text = "0,00";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürün_Raporları yenisayfa = new Ürün_Raporları();
            yenisayfa.ShowDialog();

        }

        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Raporları yenisayfa = new Stok_Raporları();
            yenisayfa.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select miktar From Ürünler where barkod=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", listView1.SelectedItems[0].Text);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }
            baglanti.Close();
            int stok = Convert.ToInt32(textBox2.Text);
            int sayi = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            if (listView1.SelectedItems.Count == 1)

            {
                sayi++;
                if (stok >= sayi)
                {
                    listView1.SelectedItems[0].SubItems[3].Text = sayi.ToString();
                }
                else
                {
                    MessageBox.Show("Bu Üründen Daha Fazla Ekleyemessiniz Çünkü Stokta Daha Fazla Ürün Kalmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            toplam();
        }
        private void satis()
        {
            //barkod      tb3
            //ürün        tb4
            //miktar      tb5   -   tb6   -  tb7
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                textBox3.Text = listView1.Items[i].SubItems[0].Text.ToString();
                textBox4.Text = listView1.Items[i].SubItems[1].Text.ToString();
                textBox6.Text = listView1.Items[i].SubItems[3].Text.ToString();


                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Select urun,miktar From Ürünler where barkod=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox3.Text);
                OleDbDataReader dr = komut.ExecuteReader();


                while (dr.Read())
                {
                    textBox5.Text = dr["miktar"].ToString();
                    textBox4.Text = dr["urun"].ToString();
                }

                if (textBox5.Text == "")
                {
                    textBox5.Text = "0";
                }
                if (textBox6.Text == "")
                {
                    textBox6.Text = "0";
                }
                int sayi1 = int.Parse(textBox5.Text);
                int sayi2 = int.Parse(textBox6.Text);
                int sonuc = sayi1 - sayi2;
                textBox7.Text = sonuc.ToString();

                OleDbCommand komut2 = new OleDbCommand("update Ürünler set miktar='" + textBox7.Text + "' where barkod='" + textBox3.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                miktarstokrapor();
            } 
        }
        private void miktarstokrapor()
        {
                baglanti.Open();

                string tur = "Satış";
                string barkod = textBox3.Text.ToString();
                string urun = textBox4.Text.ToString();
                string miktar = textBox6.Text.ToString();
                string tarih = dateTimePicker1.Value.ToString();
                OleDbCommand komut3 = new OleDbCommand("insert into SRapor (Barkod,Ürün,Miktar,Yapılan_İşlem,Tarih) values ('" + barkod + "','" + urun + "','" + miktar + "','" + tur + "','" + tarih + "')", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == cevap)
            {
                Close();
            }
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altbaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int hiza =250;
            int althiza = 350;
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Mehmet Market", Baslik, sb, 300, 100, st);

            e.Graphics.DrawString("------------------------------------------------", altbaslik, sb, 300, 120, st);
            e.Graphics.DrawString("Ürün Adı             Fiyat              Adet", altbaslik, sb, 300, 150, st);
            e.Graphics.DrawString("------------------------------------------------", altbaslik, sb, 300, 180, st);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, icerik, sb, 300, hiza, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[2].Text+ "₺", icerik, sb, 450, hiza, st);
                e.Graphics.DrawString(listView1.Items[i].SubItems[3].Text, icerik, sb, 600, hiza, st);
                hiza = hiza + 20;
                althiza = althiza + 20;
            }
            e.Graphics.DrawString("------------------------------------------------", altbaslik, sb, 300, althiza, st);
            althiza = althiza + 20;
            e.Graphics.DrawString("Toplam Tutar:      " + label2.Text + "₺", altbaslik, sb, 300, althiza, st);
            althiza = althiza + 20;
            e.Graphics.DrawString("------------------------------------------------", altbaslik, sb, 300, althiza, st);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void barkodOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barkodolustur yenisayfa = new barkodolustur();
            yenisayfa.ShowDialog();
        }

        private void karekodOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            QR yenisayfa = new QR();
            yenisayfa.ShowDialog();
        }
    }
}
