using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisDiscussionForum
{
    public partial class Home : Form
    {

        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlConnection cn;
        System.Data.SqlClient.SqlDataReader dr;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4Q2122\CPE106\FinalProj\ThesisDiscussionForum\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You logged out. ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            label1.Text = Login.username;
            cmd = new System.Data.SqlClient.SqlCommand("select * from LoginTable where user_email='" + label1.Text);
        }
    }
}
