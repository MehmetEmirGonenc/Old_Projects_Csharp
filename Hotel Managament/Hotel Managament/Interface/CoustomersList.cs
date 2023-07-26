using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Managament
{
    public partial class CoustomersList : Form
    {
        public CoustomersList()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Hotel;Integrated Security=True");


        private void ShowDatas()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Coustomers",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void DeleteData(string nameofdelete)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Coustomers where FirstName='"+nameofdelete+"'",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void CoustomersList_Load(object sender, EventArgs e)
        {
            ShowDatas();
            textBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToString();
            string varable = comboBox1.Text.ToString();
            connection.Open();

            
            SqlCommand cmd = new SqlCommand("select * from Coustomers where " + varable + " like '%" + search + "%' ", connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresault = MessageBox.Show("Sure?", "Are you sure you want to delete coustomer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresault == DialogResult.Yes)
            {
                connection.Open();
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    DeleteData(drow.Cells[0].Value.ToString());
                    string coustomerid = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    //Logging        !!!!!!!!!!!!Not Finished
                    SqlCommand logcmd0 = new SqlCommand("insert into log(ExitCoustomerDT,ExitCoustomerId,ExitCoustomerStaff) values ('"+DateTime.Now+"','"+coustomerid+"',,)",connection);
                    logcmd0.ExecuteNonQuery();
                    //-Logging
                }
                ShowDatas();
                connection.Close();
            }
        }
    }
}
