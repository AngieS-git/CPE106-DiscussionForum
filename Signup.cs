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
    public partial class Signup : Form
    {

        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlConnection cn;
        System.Data.SqlClient.SqlDataReader dr;

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4Q2122\CPE106\FinalProj\ThesisDiscussionForum\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (password_tbox.Text != string.Empty || password_tbox.Text != string.Empty || username_tbox.Text != string.Empty || email_tbox.Text != string.Empty)
            {
                if (password_tbox.Text == confirmpass_tbox.Text)
                {
                    cmd = new System.Data.SqlClient.SqlCommand("select * from LoginTable where user_name='" + username_tbox.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new System.Data.SqlClient.SqlCommand("insert into LoginTable values(@uid,@user_name,@user_password,@user_email,@user_course)", cn);
                        cmd.Parameters.AddWithValue("uid", username_tbox.Text);
                        cmd.Parameters.AddWithValue("user_name", username_tbox.Text);
                        cmd.Parameters.AddWithValue("user_password", password_tbox.Text);
                        cmd.Parameters.AddWithValue("user_email", email_tbox.Text);
                        cmd.Parameters.AddWithValue("user_course", course_tbox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Confirm Password Incorrect! ", "Error(01)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter information in all fields.", "Error(02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
        }
    }
}
