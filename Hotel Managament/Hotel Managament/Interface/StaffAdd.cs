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
    public partial class StaffAdd : Form
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Hotel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //Gender
            string gender="";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            if (radioButton2.Checked)
            {
                gender = "Female";
            }

            //
            string name = textBox1.Text.ToString();
            string surname = textBox2.Text.ToString();
            string idientity = textBox3.Text.ToString();
            string telephone = maskedTextBox1.Text.ToString();
            string BirthOD = dateTimePicker1.Value.ToString();
            string insuranceNo = textBox4.Text.ToString();
            string adress = richTextBox1.Text.ToString();
            string department = textBox5.Text.ToString();
            int wage = Convert.ToInt32(textBox6.Text);
            string SJD = dateTimePicker2.Value.ToString();
            DialogResult dialogresault = MessageBox.Show("Sure?", "Are you sure you want to add new staff?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresault == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Staffs(FirstName,LastName,IdientityNo,TelephoneNo,BirthOfDate,InsuranceNo,Adress,Department,Wage,StartJobDate,gender)" +
                    "values ('" + name + "','" + surname + "','" + idientity + "','" + telephone + "','" + BirthOD + "','" + insuranceNo + "','" + adress + "','" + department + "','" + wage + "','" + SJD + "','"+gender+"')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }



        }
    }
}
