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
    public partial class Chaptcha : Form
    {
        public Chaptcha()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=MEHMET;Initial Catalog=Hotel;Integrated Security=True");
        static public string authority;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text.ToString(); 
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where username='"+username+"' and password='"+password+"'", connection);
            if (cmd.ExecuteReader().Read())
            {
                Main_Menu main_Menu = new Main_Menu();
                main_Menu.Show();
                this.Hide();
                connection.Close();
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("select authority from users where username ='" + username + "'", connection);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    authority = dr[0].ToString();
                }
                //Logging
                connection.Close();
                connection.Open();
                SqlCommand logcmd = new SqlCommand("Insert into log(succesfullylogin) values ('"+DateTime.Now+"')", connection);
                logcmd.ExecuteNonQuery();
                connection.Close();
                //-Logging
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                label3.Text = "Wrong Username or Password!";
                //Logging
                connection.Open();
                SqlCommand logcmd1 = new SqlCommand("insert into log(Faillogin) values ('"+DateTime.Now+"')", connection);
                logcmd1.ExecuteNonQuery();
                connection.Close();
                //-Logging
            }
            
        }

        private void Chaptcha_Load(object sender, EventArgs e)
        {
            //Logging
            connection.Open();
            SqlCommand logcmd2 = new SqlCommand("insert into log(OpenSoftware) values ('"+DateTime.Now+"')", connection);
            logcmd2.ExecuteNonQuery();
            connection.Close();
            //-Logging
        }
    }
}
