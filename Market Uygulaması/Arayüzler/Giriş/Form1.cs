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

namespace Barkod_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        
        private void giriş()
        {
            Barkod_Uygulaması.Properties.Settings.Default.ayrac = 0;
            
            string gsifre;
            string gkullanıcı;

            string psifre;
            string sifre;
            string sifre1;
            string sifre2;
            string sifre3;
            string sifre4;
            string sifre5;
            string sifre6;
            string sifre7;
            string sifre8;
            string sifrea;
            string sifrea1;

            string kullanıcı;
            string pkullanıcı;
            string ka1;
            string ka2;
            string ka3;
            string ka4;
            string ka5;
            string ka6;
            string ka7;
            string ka8;
            string kaa;
            string kaa1;
            //Geçici Değişkenler.
            gsifre = textBox2.Text;
            gkullanıcı = textBox1.Text;
            //Değişken Textbox Tanımlaması.
            sifre = Barkod_Uygulaması.Properties.Settings.Default.sifre;
            psifre = Barkod_Uygulaması.Properties.Settings.Default.psifre;
            sifre1 = Barkod_Uygulaması.Properties.Settings.Default.sifre1;
            sifre2 = Barkod_Uygulaması.Properties.Settings.Default.sifre2;
            sifrea = Barkod_Uygulaması.Properties.Settings.Default.sifrea;
            sifrea1 = Barkod_Uygulaması.Properties.Settings.Default.sifrea1;
            kullanıcı = Barkod_Uygulaması.Properties.Settings.Default.ka;
            pkullanıcı = Barkod_Uygulaması.Properties.Settings.Default.pka;

            ka1 = Barkod_Uygulaması.Properties.Settings.Default.ka1;
            ka2 =Barkod_Uygulaması.Properties.Settings.Default.ka2 ;
            kaa =Barkod_Uygulaması.Properties.Settings.Default.kaa ;
            kaa1=Barkod_Uygulaması.Properties.Settings.Default.kaa1;
            //Değişkenlerin Geçici Değişkenlere Atanması.

            if (gsifre == sifre && gkullanıcı == kullanıcı || gsifre==sifrea && gkullanıcı == kaa || gsifre==sifrea1 && gkullanıcı==kaa1)
            {
                Barkod_Uygulaması.Properties.Settings.Default.ayrac = 1;
                Form2 yenisayfa = new Form2();
                this.Hide();
                yenisayfa.ShowDialog();
                this.Show();
            }
            else
            {
                if (gsifre=="admin"&&gkullanıcı=="admin123" ||gsifre == psifre && gkullanıcı == pkullanıcı || gsifre == sifre1 && gkullanıcı == ka1 || gsifre == sifre2 && gkullanıcı == ka2 )
                    
                    
                {
                    Form2 yenisayfa = new Form2();
                    this.Hide();
                    yenisayfa.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            giriş();
        }
    }
}
