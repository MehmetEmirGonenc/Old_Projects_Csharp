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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=Mehmet;Initial Catalog=Hotel;Integrated Security=True");

        private void ShowDatas()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Users", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void DeleteData(string nameofdelete)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Users where StaffIdientity ='" + nameofdelete + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            pictureBox5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Authority
            string authority = "User";
            if (radioButton1.Checked)
            {
                authority = "Administator";
            }
            else
            {
                authority = "User";
            }

            string idientity = textBox1.Text.ToString();
            string username = textBox2.Text.ToString();
            string password = textBox3.Text.ToString();
            string masterkey = textBox4.Text.ToString();

            connection.Open();
            SqlCommand cmd0 = new SqlCommand("select masterkey from settings where Number =1", connection);
            SqlDataReader dr = cmd0.ExecuteReader();
            if (dr.Read())
            {
                string truekey = dr["Masterkey"].ToString();
                connection.Close();
                if (masterkey == truekey)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into users (StaffIdientity,Username,Password,Authority) values ('" + idientity + "','" + username + "','" + password + "','" + authority + "')", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                DeleteData(drow.Cells[0].Value.ToString());
            }
            ShowDatas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idientity = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string username = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string password = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string authority = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            string masterkey = textBox9.Text.ToString();

            connection.Open();
            SqlCommand cmd0 = new SqlCommand("select masterkey from settings where Number =1", connection);
            SqlDataReader dr = cmd0.ExecuteReader();
            if (dr.Read())
            {
                string truekey = dr["Masterkey"].ToString();
                connection.Close();
                if (masterkey == truekey)
                {
                    connection.Open();
                    if (idientity != textBox6.Text)
                    {
                        SqlCommand cmd1 = new SqlCommand("update Users set StaffIdientity='"+textBox6.Text.ToString()+ "' where StaffIdientity='"+idientity+"'", connection);
                        cmd1.ExecuteNonQuery();
                    }
                    if (username != textBox7.Text)
                    {
                        SqlCommand cmd2 = new SqlCommand("update Users set Username='" + textBox7.Text.ToString() + "' where StaffIdientity='" + idientity + "'", connection);
                        cmd2.ExecuteNonQuery();
                    }
                    if (password != textBox8.Text)
                    {
                        SqlCommand cmd3 = new SqlCommand("update Users set Password='" + textBox8.Text.ToString() + "' where StaffIdientity='" + idientity + "'", connection);
                        cmd3.ExecuteNonQuery();
                    }
                    if (radioButton4.Checked)
                    {
                        if(authority== "Administator")
                        {
                            SqlCommand cmd4 = new SqlCommand("update Users set authority='User' where StaffIdientity='" + idientity + "'", connection);
                            cmd4.ExecuteNonQuery();
                        }
                    }
                    if (radioButton3.Checked)
                    {
                        if (authority == "User")
                        {
                            SqlCommand cmd5 = new SqlCommand("update Users set authority='Administator' where StaffIdientity='" + idientity + "'", connection);
                            cmd5.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Users", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
            panel4.Show();
            panel1.Hide();
            pictureBox5.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            //Authority
            if(dataGridView2.CurrentRow.Cells[3].Value.ToString() == "Administator")
            {
                radioButton3.Checked = true;
            }
            if (dataGridView2.CurrentRow.Cells[3].Value.ToString() == "User")
            {
                radioButton4.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            pictureBox5.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            pictureBox5.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Show();
            pictureBox5.Show();
            ShowDatas();
        }
    }
}
