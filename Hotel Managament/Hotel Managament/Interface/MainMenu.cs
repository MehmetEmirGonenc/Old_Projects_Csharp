using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managament
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCoustomer ecoustomer = new EditCoustomer();
            ecoustomer.Show();
            

        }

        private void exitryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffAdd saform = new StaffAdd();
            saform.Show();
           
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffAdd saform = new StaffAdd();
            saform.Show();
            
        }

        private void staffsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffEdit edit1 = new StaffEdit();
            edit1.Show();
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList stafflist = new StaffList();
            stafflist.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Logging

            //-Logging
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.Show();
        }

        private void usuersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            if(Chaptcha.authority == "Administator")
            {
                label1.Text = "Admin";
            }
            else
            {
                label1.Text = "User";
                label1.ForeColor = Color.Blue;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void puscherpaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
