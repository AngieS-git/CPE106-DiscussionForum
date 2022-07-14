namespace CPE106
{
    public partial class HomePage : Form
    {
        /*
        Image onHoverUp = Image.FromFile(@"D:\MAPUA\2nd Year\4th Term\CPE106\CPE106\onHoverup.png");
        Image Up = Image.FromFile(@"D:\MAPUA\2nd Year\4th Term\CPE106\CPE106\upvote.png");
        Image OnclickUp= Image.FromFile(@"D:\MAPUA\2nd Year\4th Term\CPE106\CPE106\OnClickUp.png");
        */
        int counterUpvote1 = 220;
        int counterUpvote2 = 3244;
        int i = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "search...")
            {
                searchBar.Text = " ";
                searchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "search...";
                searchBar.ForeColor = Color.Silver;
            }
        }

        private void searchTag_Enter(object sender, EventArgs e)
        {
            if (searchTag.Text == "search by tag")
            {
                searchTag.Text = " ";
                searchTag.ForeColor = Color.Black;
            }
        }

        private void searchTag_Leave(object sender, EventArgs e)
        {
            if (searchTag.Text == "")
            {
                searchTag.Text = "search by tag";
                searchTag.ForeColor = Color.Silver;
            }
        }

        private void PostQuestion_Enter(object sender, EventArgs e)
        {
            if (PostQuestion.Text == "Post a question...")
            {
                PostQuestion.Text = " ";
                PostQuestion.ForeColor = Color.Black;
            }
        }

        private void PostQuestion_Leave(object sender, EventArgs e)
        {
            if (PostQuestion.Text == "")
            {
                PostQuestion.Text = "Post a question...";
                PostQuestion.ForeColor = Color.Silver;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void searchTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void upvote1_Click(object sender, EventArgs e)
        {
            //this.upvote1.BackColor = Color.FromArgb(255, 98, 98);
         
            i++;
            switch (i)
            {
                case 1:
                    counterUpvote1++;
                    label1.Text = counterUpvote1.ToString();
                    this.upvote1.BackColor = Color.FromArgb(255, 98, 98);
                    break;
                case 2:
                    upvote1.BackColor = Color.FromArgb(214, 214, 214);
                    counterUpvote1--;
                    label1.Text = counterUpvote1.ToString();
                    i = 0;
                    break;
            }
        }


        private void downvote1_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    counterUpvote1--;
                    label1.Text = counterUpvote1.ToString();
                    this.downvote1.BackColor = Color.FromArgb(98, 160, 218);
                    break;
                case 2:
                    counterUpvote1++;
                    label1.Text = counterUpvote1.ToString();
                    downvote1.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            i++;
            
            switch (i)
            {
                case 1:
                    counterUpvote2++;
                    label3.Text = counterUpvote2.ToString();
                    this.button8.BackColor = Color.FromArgb(255, 98, 98);
                    break;
                case 2:
                    counterUpvote2--;
                    label3.Text = counterUpvote2.ToString();
                    button8.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    counterUpvote2--;
                    label3.Text = counterUpvote2.ToString();
                    this.button6.BackColor = Color.FromArgb(98, 160, 218);
                    break;
                case 2:
                    button6.BackColor = Color.FromArgb(214, 214, 214);
                    counterUpvote2++;
                    label3.Text = counterUpvote2.ToString();
                    i = 0;
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    this.button10.BackColor = Color.FromArgb(255, 98, 98);
                    break;
                case 2:
                    button10.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    this.button9.BackColor = Color.FromArgb(98, 160, 218);
                    break;
                case 2:
                    button9.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bookmark1_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    this.bookmark1.BackColor = Color.FromArgb(255,164,27);
                    break;
                case 2:
                    bookmark1.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void bookmark2_Click(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    this.bookmark2.BackColor = Color.FromArgb(255, 164, 27);
                    break;
                case 2:
                    bookmark2.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            i++;
            switch (i)
            {
                case 1:
                    this.button11.BackColor = Color.FromArgb(255, 164, 27);
                    break;
                case 2:
                    this.button11.BackColor = Color.FromArgb(214, 214, 214);
                    i = 0;
                    break;
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{

		}

		private void PostQuestion_TextChanged(object sender, EventArgs e)
		{

		}

		private void searchTag_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
