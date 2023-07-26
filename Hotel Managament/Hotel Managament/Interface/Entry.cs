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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //In here we start the database Commands

        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Hotel;Integrated Security=True");


        private void cleartextbox()
        {
            FirstName.Text = "";
            LastName.Text = "";
            IdientityNo.Text = "";
            PassaportNo.Text = "";
            maskedTextBox1.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked= false;
            radioButton2.Checked = false;
            Mail.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }






        private void button1_Click(object sender, EventArgs e)
        {
            //gender varable
            string gender="";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            //varables
            string name = FirstName.Text.ToString();
            string surname = LastName.Text.ToString();
            string idientity = IdientityNo.Text.ToString();
            string passaport = PassaportNo.Text.ToString();
            string mail = Mail.Text.ToString();
            string adress = richTextBox1.Text.ToString();
            int roomno = Convert.ToInt32(comboBox1.Text);
            string telno = maskedTextBox1.Text.ToString();
            string entrydate = dateTimePicker1.Value.ToString();
            string exitrydate = dateTimePicker2.Value.ToString();
            


            connection.Open();
            if (IdientityNo.Text == "")
            {
                SqlCommand command2 = new SqlCommand("insert into Coustomers (FirstName,LastName,PassaporNo,mail,adress,RoomNo,TelephoneNo,EnterDate,ExitDate,gender) values ('" + name + "','" + surname + "','" + passaport + "','" + mail + "','" + adress + "','" + roomno + "','" + telno + "','" + entrydate + "','" + exitrydate + "','" + gender + "')", connection);
                command2.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (PassaportNo.Text == "")
            {
                SqlCommand command = new SqlCommand("insert into Coustomers (FirstName,LastName,IdientityNo,mail,adress,RoomNo,TelephoneNo,EnterDate,ExitDate,gender) values ('" + name + "','" + surname + "','" + idientity + "','" + mail + "','" + adress + "','" + roomno + "','" + telno + "','" + entrydate + "','" + exitrydate + "','"+gender+"')", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
            //Logging   !!!!!!!!!Do Here Not Finished
            connection.Open();
            SqlCommand logcmd0 = new SqlCommand("insert into log(RegisterDT,RegisterStaff,RegisterCoustomerId) values ('"+DateTime.Now+"','','"+idientity+"')", connection);
            logcmd0.ExecuteNonQuery();
            connection.Close();
            //-Logging
        }

        private void IdientityNo_TextChanged(object sender, EventArgs e)
        {
            if (IdientityNo.Text == "")
            {
                PassaportNo.Enabled = true;
            }
            else
            {
                PassaportNo.Enabled = false;
            }
        }

        private void PassaportNo_TextChanged(object sender, EventArgs e)
        {
            if (PassaportNo.Text == "")
            {
                IdientityNo.Enabled = true;
            }
            else
            {
                IdientityNo.Enabled = false;
            }
        }
    }
}
