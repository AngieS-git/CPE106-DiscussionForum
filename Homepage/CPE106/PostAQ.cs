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
	public partial class PostAQ : Form
	{
		public PostAQ()
		{
			InitializeComponent();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomePage HP = new HomePage();
			HP.Show();
		}
	}
}
