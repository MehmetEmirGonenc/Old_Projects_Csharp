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

namespace Hotel_Managament
{
    public partial class EditCoustomer : Form
    {
        public EditCoustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=MEHMET;Initial Catalog=Hotel;Integrated Security=True");

        private void ShowDates()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Coustomers", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string LastName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idientity = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string passaport = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string mail = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string adress = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string RoomNo = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string TelephoneNo = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string enterdate = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string exitdate = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            textBox2.Text = FirstName;
            textBox3.Text = LastName;
            textBox5.Text = idientity;
            textBox4.Text = passaport;
            textBox6.Text = TelephoneNo;
            textBox7.Text = mail;
            textBox9.Text = enterdate;
            textBox10.Text = exitdate;

            richTextBox1.Text = adress;
            comboBox2.Text = RoomNo;
            //gender
            if(gender == "Male") 
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            panel1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditCoustomer_Load(object sender, EventArgs e)
        {
            ShowDates();
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FirstName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string LastName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idientity = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string passaport = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string mail = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string adress = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string RoomNo = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string TelephoneNo = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string enterdate = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string exitdate = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            string FirstNameC = textBox2.Text.ToString();
            string LastNameC=textBox3.Text.ToString();
            string idientityC=textBox5.Text.ToString();
            string passaportC=textBox4.Text.ToString();
            string mailC=textBox7.Text.ToString();
            string TelephoneNoC = textBox6.Text.ToString();
            string adressC = richTextBox1.Text.ToString();
            string enterydateC = textBox9.Text.ToString();
            string exitdateC = textBox10.Text.ToString();
            string RoomNoC = comboBox2.Text.ToString();
            string genderC = "Male";
            //gender
            if(radioButton1.Checked == true)
            {
                genderC = "Male";
            }
            else
            {
                genderC = "Female";
            }

            connection.Open();

            if(FirstName != FirstNameC)
            {
                SqlCommand cmd0 = new SqlCommand("update Coustomers set FirstName='"+FirstNameC+"' where idientity='"+idientity+"'", connection);
                cmd0.ExecuteNonQuery();
            }
            if(LastName != LastNameC)
            {
                SqlCommand cmd1 = new SqlCommand("update Coustomers set LastName='" + LastNameC + "' where idientity='" + idientity + "'", connection);
                cmd1.ExecuteNonQuery();
            }
            if(idientity != idientityC)
            {
                SqlCommand cmd2 = new SqlCommand("update Coustomers set Idientity='" + idientityC + "' where idientity='" + idientity + "'", connection);
                cmd2.ExecuteNonQuery();
            }
            if(mail != mailC)
            {
                SqlCommand cmd3 = new SqlCommand("update Coustomers set Idientity='" + mailC + "' where idientity='" + idientity + "'", connection);
                cmd3.ExecuteNonQuery();
            }
            if (adress != adressC)
            {
                SqlCommand cmd4 = new SqlCommand("update Coustomers set Idientity='" + adressC + "' where idientity='" + idientity + "'", connection);
                cmd4.ExecuteNonQuery();
            }
            if (RoomNo != RoomNoC)
            {
                SqlCommand cmd5 = new SqlCommand("update Coustomers set Idientity='" + RoomNoC + "' where idientity='" + idientity + "'", connection);
                cmd5.ExecuteNonQuery();
            }
            if (TelephoneNo != TelephoneNoC)
            {
                SqlCommand cmd6 = new SqlCommand("update Coustomers set Idientity='" + TelephoneNoC + "' where idientity='" + idientity + "'", connection);
                cmd6.ExecuteNonQuery();
            }
            if (enterdate != enterydateC)
            {
                SqlCommand cmd7 = new SqlCommand("update Coustomers set Idientity='" + enterydateC + "' where idientity='" + idientity + "'", connection);
                cmd7.ExecuteNonQuery();
            }
            if (exitdate != exitdateC)
            {
                SqlCommand cmd8 = new SqlCommand("update Coustomers set Idientity='" + exitdateC + "' where idientity='" + idientity + "'", connection);
                cmd8.ExecuteNonQuery();
            }
            if (gender != genderC)
            {
                SqlCommand cmd9 = new SqlCommand("update Coustomers set Idientity='" + genderC + "' where idientity='" + idientity + "'", connection);
                cmd9.ExecuteNonQuery();
            }
        }
    }
}
