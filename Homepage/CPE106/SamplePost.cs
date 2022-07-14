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
	public partial class SamplePost : Form
	{
		public SamplePost()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_Enter(object sender, EventArgs e)
		{
			if (richTextBox1.Text == "What are your thoughts?")
			{
				richTextBox1.Text = " ";
				richTextBox1.ForeColor = Color.Black;
			}
		}

		private void richTextBox1_Leave(object sender, EventArgs e)
		{
			if (richTextBox1.Text == "")
			{
				richTextBox1.Text = "What are your thoughts?";
				richTextBox1.ForeColor = Color.Silver;
			}
		}
	}
}
