using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void kayitgiris()
        {
            string kullanıcı;
            string pkullanıcı;
            string ka1;
            string ka2;
            string kaa;
            string kaa1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            pkullanıcı = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            //Değişkenlerin Geçici Değişkenlere Atanması.

            label30.Text = kullanıcı;
            label29.Text = kaa;
            label28.Text = kaa1;
            label27.Text = pkullanıcı;
            label26.Text = ka1;
            label25.Text = ka2;
            if (label30.Text=="")
            {
                button31.Visible = true;
            }
            else
            {
                linkLabel1.Visible = true;
            }
            //
            if (label29.Text == "")
            {
                button32.Visible = true;
            }
            else
            {
                linkLabel2.Visible = true;
            }
            //
            if (label28.Text == "")
            {
                button33.Visible = true;
            }
            else
            {
                linkLabel3.Visible = true;
            }
            //
            if (label27.Text == "")
            {
                button34.Visible = true;
            }
            else
            {
                linkLabel4.Visible = true;
            }
            //
            if (label26.Text == "")
            {
                button35.Visible = true;
            }
            else
            {
                linkLabel5.Visible = true;
            }
            //
            if (label25.Text == "")
            {
                button36.Visible = true;
            }
            else
            {
                linkLabel6.Visible = true;
            }
        }
    
        private void yenile()
        {
            string kullanıcı;
            string pkullanıcı;
            string ka1;
            string ka2;
            string kaa;
            string kaa1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            pkullanıcı = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            //Değişkenlerin Geçici Değişkenlere Atanması.

            //Not:Label1,Label2,Label3 Yönetici Hesaplara ait.
            //Admin Hesapları Olasılıkları:
            if (kullanıcı != "")
            {
                label1.Text = kullanıcı;
                if (kaa != "")
                {
                    label2.Text = kaa;
                    if (kaa1 != "")
                    {
                        label3.Text = kaa1;
                    }
                }
                else
                {
                    if (kaa1 != "")
                    {
                        label2.Text = kaa1;
                    }
                }
            }
            //1.Olasılık.
            else
            {
                if (kaa != "")
                {
                    label1.Text = kaa;
                    if (kaa1 != "")
                    {
                        label2.Text = kaa1;
                    }
                }
                //2.Olasılık.
                else
                {
                    if (kaa1 != "")
                    {
                        label1.Text = kaa1;
                    }

                }
                //3.OLasılık.
                //Personel HEsapları Olasılıkları:
            }
            if (pkullanıcı != "")
            {
                label4.Text = pkullanıcı;
                if (ka1 != "")
                {
                    label5.Text = ka1;
                    if (ka2 != "")
                    {
                        label6.Text = ka2;
                    }
                }
            }
            //1.Olasılık.
            else
            {
                if (ka1 != "")
                {
                    label4.Text = ka1;
                    if (ka2 != "")
                    {
                        label5.Text = ka2;
                    }
                }
                //2.Olasılık.
                else
                {
                    if (ka2 != "")
                    {
                        label4.Text = ka2;
                    }
                }
                //3.Olasılık
            }
        }
        private void gizle()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            //Kayıt Bölümü:
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            linkLabel1.Visible =false;
            linkLabel2.Visible =false;
            linkLabel3.Visible =false;
            linkLabel4.Visible =false;
            linkLabel5.Visible =false;
            linkLabel6.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            yenile();
            gizle();
            kayitgiris();
        }

        private void hesapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void hesaplarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }


        /////////////////////////////////////////////////
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Başlıyor!!//
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
        /////////////////////////////////////////////////
        

        private void button19_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kullanıcı == label1.Text && sifre == textBox1.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.sifre = textBox2.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox1.Clear();
                    textBox2.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre + "'");
                }
                else
                {
                    if (kaa == label1.Text && sifrea == textBox1.Text)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.sifrea = textBox2.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox1.Clear();
                        textBox2.Clear();
                        yenile();
                        MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifrea + "'");
                    }
                    else
                    {
                        if (kaa1 == label1.Text && sifrea1 == textBox1.Text)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.sifrea1 = textBox2.Text;
                            Barkod_Uygulaması.Properties.Settings.Default.Save();
                            textBox1.Clear();
                            textBox2.Clear();
                            yenile();
                            MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifrea1 + "'");
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                        }
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kullanıcı == label1.Text && sifre == textBox1.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka = textBox3.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox1.Clear();
                    textBox3.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka + "'");
                }
                else
                {
                    if (kaa == label1.Text && sifrea == textBox1.Text)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.kaa = textBox3.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox1.Clear();
                        textBox3.Clear();
                        yenile();
                        MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.kaa + "'");
                    }
                    else
                    {
                        if (kaa1 == label1.Text && sifrea1 == textBox1.Text)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.kaa1 = textBox3.Text;
                            Barkod_Uygulaması.Properties.Settings.Default.Save();
                            textBox1.Clear();
                            textBox3.Clear();
                            yenile();
                            MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.kaa1 + "'");
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label9.Visible == true)
            {
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
            }
            else
            {
                label7.Visible = true;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox3.Visible = true;
                button20.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label8.Visible == true)
            {
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
            }
            else
            {
                label7.Visible = true;
                label8.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button19.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label12.Visible == true)
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
            }
            else
            {
                label10.Visible = true;
                label12.Visible = true;
                textBox4.Visible = true;
                textBox6.Visible = true;
                button21.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label11.Visible == true)
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
            }
            else
            {
                label10.Visible = true;
                label11.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button22.Visible = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kaa == label2.Text && sifrea == textBox4.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa = textBox6.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox4.Clear();
                    textBox6.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.kaa + "'");
                }
                else
                {
                    if (kaa1 == label2.Text && sifrea1 == textBox4.Text)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.kaa1 = textBox6.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox4.Clear();
                        textBox6.Clear();
                        yenile();
                        MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.kaa1 + "'");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kaa == label2.Text && sifrea == textBox4.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.sifrea = textBox5.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox4.Clear();
                    textBox5.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifrea + "'");
                }
                else
                {
                    if (kaa1 == label2.Text && sifrea1 == textBox4.Text)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.sifrea1 = textBox5.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox4.Clear();
                        textBox5.Clear();
                        yenile();
                        MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifrea1 + "'");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label15.Visible == true)
            {
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
            }
            else
            {
                label13.Visible = true;
                label15.Visible = true;
                textBox7.Visible = true;
                textBox9.Visible = true;
                button23.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label14.Visible == true)
            {
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button23.Visible = false;
                button24.Visible = false;
            }
            else
            {
                label13.Visible = true;
                label14.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                button24.Visible = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox7.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kaa1 == label3.Text && sifrea1 == textBox7.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa1 = textBox9.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox7.Clear();
                    textBox9.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.kaa1 + "'");
                }
                else
                {
                    MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string sifre;
            string sifrea;
            string sifrea1;

            string kaa;
            string kaa1;
            string kullanıcı;

            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;

            if (textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (kaa1 == label3.Text && sifrea1 == textBox7.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.sifrea1 = textBox8.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox7.Clear();
                    textBox8.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifrea1 + "'");
                }
                else
                {
                    MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label18.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
            }
            else
            {
                label16.Visible = true;
                label18.Visible = true;
                textBox10.Visible = true;
                textBox12.Visible = true;
                button25.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label17.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
            }
            else
            {
                label16.Visible = true;
                label17.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                button26.Visible = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox10.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label4.Text == pka && textBox10.Text == psifre)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.pka = textBox12.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox10.Clear();
                    textBox12.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.pka + "'");
                }
                else
                {
                    if (label4.Text == ka1 && textBox10.Text == sifre1)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.ka1 = textBox12.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox10.Clear();
                        textBox12.Clear();
                        yenile();
                        MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka1 + "'");
                    }
                    else
                    {
                        if (label4.Text == ka2 && textBox10.Text == sifre2)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.ka2 = textBox12.Text;
                            Barkod_Uygulaması.Properties.Settings.Default.Save();
                            textBox10.Clear();
                            textBox12.Clear();
                            yenile();
                            MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka2 + "'");
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                        }
                    }
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label4.Text == pka && textBox10.Text == psifre)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.psifre = textBox11.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox10.Clear();
                    textBox11.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.psifre + "'");
                }
                else
                {
                    if (label4.Text == ka1 && textBox10.Text == sifre1)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.sifre1 = textBox11.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox10.Clear();
                        textBox11.Clear();
                        yenile();
                        MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre1 + "'");
                    }
                    else
                    {
                        if (label4.Text == ka2 && textBox10.Text == sifre2)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.sifre2 = textBox11.Text;
                            Barkod_Uygulaması.Properties.Settings.Default.Save();
                            textBox10.Clear();
                            textBox11.Clear();
                            yenile();
                            MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre2 + "'");
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label21.Visible == true)
            {
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
            }
            else
            {
                label19.Visible = true;
                label21.Visible = true;
                textBox13.Visible = true;
                textBox15.Visible = true;
                button27.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label20.Visible == true)
            {
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
            }
            else
            {
                label19.Visible = true;
                label20.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                button28.Visible = true;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox13.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label5.Text == ka1 && textBox13.Text == sifre1)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka1 = textBox15.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox13.Clear();
                    textBox15.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka1 + "'");
                }
                else
                {
                    if (label5.Text == ka2 && textBox13.Text == sifre2)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.ka2 = textBox15.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox13.Clear();
                        textBox15.Clear();
                        yenile();
                        MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka2 + "'");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                    }
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox13.Text == "" || textBox14.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label5.Text == ka1 && textBox13.Text == sifre1)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.sifre1 = textBox14.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox13.Clear();
                    textBox14.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre1 + "'");
                }
                else
                {
                    if (label5.Text == ka2 && textBox13.Text == sifre2)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.sifre2 = textBox14.Text;
                        Barkod_Uygulaması.Properties.Settings.Default.Save();
                        textBox13.Clear();
                        textBox14.Clear();
                        yenile();
                        MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre2 + "'");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label24.Visible == true)
            {
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
            }
            else
            {
                label22.Visible = true;
                label24.Visible = true;
                textBox16.Visible = true;
                textBox18.Visible = true;
                button29.Visible = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label23.Visible == true)
            {
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
            }
            else
            {
                label22.Visible = true;
                label23.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                button30.Visible = true;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox16.Text == "" || textBox18.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Kullanıcı Adı Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label6.Text == ka2 && textBox16.Text == sifre2)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka2 = textBox18.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox16.Clear();
                    textBox18.Clear();
                    yenile();
                    MessageBox.Show("Kullanıcı Adı Başarı İle Değiştirildi.Yeni Kullanıcı Adı:'" + Barkod_Uygulaması.Properties.Settings.Default.ka2 + "'");
                }
                else
                {
                    MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string pka;
            string ka1;
            string ka2;

            string psifre;
            string sifre1;
            string sifre2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.pka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.ka2;

            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;

            if (textBox16.Text == "" || textBox17.Text == "")
            {
                MessageBox.Show("Eski Şifre Ve Yeni Şifre Kısmı Boş Bırakılamaz!");
            }
            else
            {
                if (label6.Text == ka2 && textBox16.Text == sifre2)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.sifre2 = textBox17.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    textBox16.Clear();
                    textBox17.Clear();
                    yenile();
                    MessageBox.Show("Şifre Başarı İle Değiştirildi.Yeni Şifre:'" + Barkod_Uygulaması.Properties.Settings.Default.sifre2 + "'");
                }
                else
                {
                    MessageBox.Show("Lütfen Şifrenizin Doğru Olduğundan Emin Olunuz!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string kullanıcı;
            string kaa;
            string kaa1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label1.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                if (label1.Text == kullanıcı)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka = "";
                }
                else
                {
                    if (label1.Text == kaa)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.kaa = "";
                    }
                    else
                    {
                        if (label1.Text == kaa1)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.kaa1 = "";
                        }
                        else
                        {
                            MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                        }
                    }
                }
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string kullanıcı;
            string kaa;
            string kaa1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label2.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                if (label2.Text == kaa)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa = "";
                }
                else
                {
                    if (label2.Text == kaa1)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.kaa1 = "";
                    }
                    else
                    {
                        MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                    }
                }
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string kullanıcı;
            string kaa;
            string kaa1;

            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            kaa = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            kaa1 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label3.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                if (label3.Text == kaa1)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa1 = "";
                }
                else
                {
                    MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                }
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string pka;
            string ka1;
            string ka2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.ka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label4.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                if (label4.Text == pka)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.pka = "";
                }
                else
                {
                    if (label4.Text == ka1)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.ka1 = "";
                    }
                    else
                    {
                        if (label4.Text == ka2)
                        {
                            Barkod_Uygulaması.Properties.Settings.Default.ka2 = "";
                        }
                        else
                        {
                            MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                        }
                    }
                }
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string pka;
            string ka1;
            string ka2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.ka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label5.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {

                if (label5.Text == ka1)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka1 = "";
                }
                else
                {
                    if (label5.Text == ka2)
                    {
                        Barkod_Uygulaması.Properties.Settings.Default.ka2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                    }
                }
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();

            string pka;
            string ka1;
            string ka2;

            pka = Barkod_Uygulaması.Properties.Settings.Default.ka;
            ka1 = Barkod_Uygulaması.Properties.Settings.Default.kaa;
            ka2 = Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            secim = MessageBox.Show("'" + label6.Text + "' Hesabını Silmek İstediğinizden Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                
                if (label6.Text == ka2)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka2 = "";
                }
                else
                {
                    MessageBox.Show("Silinecek Bir Hesap Kalmadı.");
                }                       
            }
            Barkod_Uygulaması.Properties.Settings.Default.Save();
            yenile();
        }
        //////////////////////////////////////////////// 
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!Hesapları Düzenleme Kısmı Burada Bitiyor!!//
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
        ////////////////////////////////////////////////
        private void button37_Click(object sender, EventArgs e)
        {
            if(textBox19.Text=="" && textBox20.Text=="" && textBox21.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if(textBox20.Text==textBox21.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka = textBox19.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.sifre = textBox20.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (textBox22.Text == "" && textBox23.Text == "" && textBox24.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox22.Text == textBox23.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa = textBox24.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.sifrea = textBox23.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (textBox25.Text == "" && textBox26.Text == "" && textBox27.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox25.Text == textBox26.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.kaa1 = textBox27.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.sifrea1 = textBox26.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (textBox28.Text == "" && textBox29.Text == "" && textBox30.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox29.Text == textBox28.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.pka = textBox30.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.psifre = textBox29.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (textBox31.Text == "" && textBox32.Text == "" && textBox33.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox31.Text == textBox32.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka1 = textBox33.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.sifre1 = textBox32.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (textBox34.Text == "" && textBox35.Text == "" && textBox36.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı , Şifre ve Şifre Onayı Kısımları Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBox34.Text == textBox35.Text)
                {
                    Barkod_Uygulaması.Properties.Settings.Default.ka2 = textBox36.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.sifre2 = textBox35.Text;
                    Barkod_Uygulaması.Properties.Settings.Default.Save();
                    MessageBox.Show("Hesap Başarı ile Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Şifre Oyanıyını Doğru Yazdığınıza Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = true;
            textBox21.Visible = true;
            button37.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            button38.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = true;
            button39.Visible = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label40.Visible = true;
            label41.Visible = true;
            label42.Visible = true;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
            button40.Visible = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            label43.Visible = true;
            label44.Visible = true;
            label45.Visible = true;
            textBox31.Visible = true;
            textBox32.Visible = true;
            textBox33.Visible = true;
            button41.Visible = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            label46.Visible = true;
            label47.Visible = true;
            label48.Visible = true;
            textBox34.Visible = true;
            textBox35.Visible = true;
            textBox36.Visible = true;
            button42.Visible = true;
        }
    }
}
