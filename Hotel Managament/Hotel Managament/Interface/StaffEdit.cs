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
    public partial class StaffEdit : Form
    {
        public StaffEdit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Hotel;Integrated Security=True");

        private void ShowDatas()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Staffs", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void CoustomerEdit_Load(object sender, EventArgs e)
        {
            ShowDatas();
            textBox1.Enabled = false;
            panel1.Visible = false;
            button1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToString();
            string varable = comboBox1.Text.ToString();
            connection.Open();


            SqlCommand cmd = new SqlCommand("select * from Stafs where " + varable + " like '%" + search + "%' ", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        private void ShowDetails()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {






            }
            else
            {
                MessageBox.Show("Eroor!","Plese select just one row",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e) //change
        {
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idientity = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string insturance = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string department = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string wage = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string BOD = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string SJD = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string adress = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //Gender
            string gender = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            connection.Open();

            if (textBox2.Text != name)
            {
                SqlCommand cmd0 = new SqlCommand("update Staffs set FirstName='" + textBox2.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd0.ExecuteNonQuery();
            }
            if(textBox3.Text != surname)
            {
                SqlCommand cmd1 = new SqlCommand("update Staffs set LastName='" + textBox3.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd1.ExecuteNonQuery();
            }
            if(textBox4.Text != idientity)
            {
                SqlCommand cmd2 = new SqlCommand("update Staffs set IdientityNo='" + textBox4.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd2.ExecuteNonQuery();
            }
            if (textBox6.Text != wage)
            {
                SqlCommand cmd3 = new SqlCommand("update Staffs set Wage='" + textBox6.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd3.ExecuteNonQuery();
            }
            if (textBox7.Text != department)
            {
                SqlCommand cmd4 = new SqlCommand("update Staffs set Department='" + textBox7.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd4.ExecuteNonQuery();
            }
            if (maskedTextBox1.Text != tel)
            {
                SqlCommand cmd5 = new SqlCommand("update Staffs set TelephoneNo='" + maskedTextBox1.Text.ToString() + "' where IdientityNo='" + idientity + "'", connection);
                cmd5.ExecuteNonQuery();
            }
            if (dateTimePicker1.Text != BOD)
            {
                SqlCommand cmd6 = new SqlCommand("update Staffs set BirthOfDate='" + dateTimePicker1.Text + "' where IdientityNo='" + idientity + "'", connection);
                cmd6.ExecuteNonQuery();
            }
            if (dateTimePicker2.Text != SJD)
            {
                SqlCommand cmd7 = new SqlCommand("update Staffs set StartJobDate='" + dateTimePicker2.Text + "' where IdientityNo='" + idientity + "'", connection);
                cmd7.ExecuteNonQuery();
            }
            if(richTextBox1.Text != adress)
            {
                SqlCommand cmd8 = new SqlCommand("update Staffs set Adress='" + richTextBox1.Text + "' where IdientityNo='" + idientity + "'", connection);
                cmd8.ExecuteNonQuery();
            }
            if(textBox13.Text != insturance)
            {
                SqlCommand cmd9 = new SqlCommand("update Staffs set InsuranceNo='" + richTextBox1.Text + "' where IdientityNo='" + idientity + "'", connection);
                cmd9.ExecuteNonQuery();
            }
            if (radioButton1.Checked)
            {
                if(gender == "Female")
                {
                    SqlCommand cmd10 = new SqlCommand("update Staffs set Gender='Male' where IdientityNo='" + idientity + "'", connection);
                    cmd10.ExecuteNonQuery();
                }
            }
            if (radioButton2.Checked)
            {
                if(gender == "Male")
                {
                    SqlCommand cmd11 = new SqlCommand("update Staffs set Gender='Female' where IdientityNo='" + idientity + "'", connection);
                    cmd11.ExecuteNonQuery();
                }
            }
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e) //edit
        {
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idientity = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string insturance = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string department = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string wage = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string BOD = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string SJD = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string adress = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //Gender
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            //Writer 
            textBox2.Text = name;
            textBox3.Text = surname;
            textBox4.Text = idientity;
            textBox6.Text = wage;
            textBox7.Text = department;
            textBox13.Text = insturance;
            maskedTextBox1.Text = tel;
            richTextBox1.Text = adress;
            dateTimePicker1.Text = BOD;
            dateTimePicker2.Text = SJD;
            //Visibility
            panel1.Visible = true;
            button1.Visible = true;
        }
    }
}
