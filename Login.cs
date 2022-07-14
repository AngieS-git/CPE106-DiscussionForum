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
    public partial class Login : Form
    {
        public static string username = "";
        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlConnection cn;
        System.Data.SqlClient.SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Gosignup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            username = name_tbox.Text;
            if (pass_tbox.Text != string.Empty || name_tbox.Text != string.Empty)
            {
                cmd = new System.Data.SqlClient.SqlCommand("select * from LoginTable where user_name='" + name_tbox.Text + "' and user_password='" + pass_tbox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    username = name_tbox.Text;
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Account does not exist or incorrect credentials. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter information in all fields.", "Error(02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4Q2122\CPE106\FinalProj\ThesisDiscussionForum\Database.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
