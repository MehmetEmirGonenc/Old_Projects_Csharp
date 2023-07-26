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
    public partial class StaffList : Form
    {
        public StaffList()
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

        private void DeleteData(string nameofdelete)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Staffs where FirstName='" + nameofdelete + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            ShowDatas();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresault = MessageBox.Show("Sure?", "Are you sure you want to delete staff?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresault == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    DeleteData(drow.Cells[0].Value.ToString());
                }
                ShowDatas();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToString();
            string varable = comboBox1.Text.ToString();
            connection.Open();


            SqlCommand cmd = new SqlCommand("select * from Staffs where " + varable + " like '%" + search + "%' ", connection);
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
    }
}
