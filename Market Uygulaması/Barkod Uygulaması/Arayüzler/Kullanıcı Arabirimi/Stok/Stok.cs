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

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Stok
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");
        public void verilerigörüntüle(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        private void Stok_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Ürün İsmi";
            verilerigörüntüle("Select * From Ürünler");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ürün İsmi")
            {
                baglanti.Open();
                DataTable tablo = new DataTable();
                OleDbDataAdapter ara = new OleDbDataAdapter("Select * From Ürünler where urun like '%" + textBox1.Text.ToString() + "%'", baglanti);
                ara.Fill(tablo);
                baglanti.Close();
                dataGridView1.DataSource = tablo;
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Barkod")
                {
                    baglanti.Open();
                    DataTable tablo = new DataTable();
                    OleDbDataAdapter ara = new OleDbDataAdapter("Select * From Ürünler where barkod like '%" + textBox1.Text.ToString() + "%'", baglanti);
                    ara.Fill(tablo);
                    baglanti.Close();
                    dataGridView1.DataSource = tablo;
                }
            }
        }
    }
}
