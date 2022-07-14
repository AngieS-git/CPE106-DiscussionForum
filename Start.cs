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
    public partial class Start : Form
    {

        System.Data.SqlClient.SqlConnection cn;

        public Start()
        {
            InitializeComponent();
        }

        private void CardinalPhoto_Click(object sender, EventArgs e)
        {

        }

        private void Gosignup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void Gologin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4Q2122\CPE106\FinalProj\ThesisDiscussionForum\Database.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
