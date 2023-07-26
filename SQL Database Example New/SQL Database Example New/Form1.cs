using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Database_Example_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Shop;Integrated Security=True");

        
        private void readvalues()
        {
            connection.Open();
            SqlCommand cmdread = new SqlCommand("select * from goods",connection);
            SqlDataReader read = cmdread.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Name"].ToString();
                add.SubItems.Add(read["Quantity"].ToString());
                add.SubItems.Add(read["Cost"].ToString());
                add.SubItems.Add(read["Sale"].ToString());
                add.SubItems.Add(read["ExpiryDate"].ToString());
                add.SubItems.Add(read["Origin"].ToString());
                listView1.Items.Add(add);

            }
            connection.Close();

        }
        private void inputvalues()
        {      
            //Converting variables
            string value1 = textBox1.Text.ToString();
            int value2 = Convert.ToInt32(this.textBox2.Text);
            float value3 = (float)Convert.ToDouble(this.textBox3.Text);
            float value4 = (float)Convert.ToDouble(this.textBox4.Text);
            string value5 = "2025-12-25";
            string value6 = textBox6.Text.ToString();

            //SqlCommand cmdinput = new SqlCommand($"Insert into goods values {value1},{value2},{value3},{value4}, ,{value6}  ", connection);
            connection.Open();
            SqlCommand cmdinput = new SqlCommand("Insert into goods values '"+value1+"','"+value2+"','"+value3+"','"+value4+"','"+value5+"','"+value6+"'", connection);
            cmdinput.ExecuteNonQuery();
            connection.Close();
            readvalues();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            inputvalues();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            readvalues();
        }
    }
}
