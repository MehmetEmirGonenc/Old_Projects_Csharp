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

namespace Barkod_Uygulaması.Arayüzler.Kullanıcı_Arabirimi.Anamenu.Ürün_Seç
{
    
    public partial class Secim : Form
    {
        public static string aktarici1="";
        public static string aktarici2 = "";
        public static string aktarici3 = "";
        public static string aktarici4 = "";
        public static string aktarici5 = "";

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Ürünler.accdb");
        public Secim()
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
        private void Secim_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Ürün İsmi";
            verilerigörüntüle("Select * From Ürünler" );
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
                if(comboBox1.SelectedItem.ToString()=="Barkod")
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

        private void button1_Click(object sender, EventArgs e)
        {
            aktarici1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            aktarici2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            aktarici3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            aktarici4 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            aktarici5 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            verilerigörüntüle("Select * From Ürünler");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            verilerigörüntüle("Select * From Ürünler");
        }     
    }
}
