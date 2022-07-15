using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE106
{
	public partial class Profile : Form
	{
		public Profile()
		{
			InitializeComponent();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomePage homePage = new HomePage();
			homePage.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Bookmarks Bookmarkspage = new Bookmarks();
			Bookmarkspage.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginPage LogPage = new LoginPage();
            LogPage.Show();
		}
	}
}
