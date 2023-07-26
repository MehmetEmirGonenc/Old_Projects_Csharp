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
    public partial class Usil : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");
        OleDbCommand komut = new OleDbCommand();
        public Usil()
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from Ürünler where barkod ='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigörüntüle("Select * From Ürünler");
                textBox1.Clear();
                MessageBox.Show("Ürün Başarı İle Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkBox1.Checked == true)
            {
                string sil;
                sil = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from Ürünler where barkod='" + sil + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigörüntüle("Select * from Ürünler");
                MessageBox.Show("Ürün Başarı İle Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Usil_Load(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigörüntüle("Select * From Ürünler");
        }
    }
}
