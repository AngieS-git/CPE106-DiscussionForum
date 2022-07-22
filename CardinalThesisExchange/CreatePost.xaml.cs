using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace CardinalThesisExchange
{
    /// <summary>
    /// Interaction logic for CreatePost.xaml
    /// </summary>
    public partial class CreatePost : Window
    {
        public CreatePost()
        {
            InitializeComponent();
        }

        private void Post_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP (1) name FROM UserTable ORDER BY datetime DESC", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (title_tbox.Text != string.Empty || post_tbox.Text != string.Empty)
            {
                cmd = new SqlCommand("INSERT INTO PostTable VALUES(@title,@post,@date,@owner)", cn);
                cmd.Parameters.AddWithValue("@title", title_tbox.Text);
                cmd.Parameters.AddWithValue("@post", post_tbox.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now); //Date and Time now.
                cmd.Parameters.AddWithValue("@owner", dr.GetValue(0).ToString()); //Get User who commented aka person who logged in.
                dr.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Post Created!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Please enter information in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT title, date, owner FROM PostTable ORDER BY date DESC", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            homepage.datagrid.ItemsSource = dt.DefaultView;
        }
    }
}
