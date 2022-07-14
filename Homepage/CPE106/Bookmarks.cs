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
	public partial class Bookmarks : Form
	{
		public Bookmarks()
		{
			InitializeComponent();
		}

		private void upvote1_Click(object sender, EventArgs e)
		{
			this.upvote1.BackColor = Color.FromArgb(255, 98, 98);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.button5.BackColor = Color.FromArgb(255, 98, 98);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.button8.BackColor = Color.FromArgb(255, 98, 98);
		}
	}
}
