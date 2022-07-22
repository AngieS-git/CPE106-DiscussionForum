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
    /// Interaction logic for ViewPost.xaml
    /// </summary>
    public partial class ViewPost : Window
    {
        public ViewPost()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Comment_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP (1) name FROM UserTable ORDER BY datetime DESC", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (comment_tbox.Text != string.Empty)
            {
                cmd = new SqlCommand("INSERT INTO ReplyTable VALUES(@comment,@date,@owner)", cn);
                cmd.Parameters.AddWithValue("@comment", comment_tbox.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now); //Date and Time now.
                cmd.Parameters.AddWithValue("@owner", dr.GetValue(0).ToString()); //Get User who commented aka person who logged in.
                dr.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comment Posted!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dr.Close();
                MessageBox.Show("Please enter your comment.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            cmd = new SqlCommand("SELECT comment, owner, date FROM ReplyTable ORDER BY date DESC", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            replyGrid.ItemsSource = dt.DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT comment, owner, date FROM ReplyTable ORDER BY date DESC", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            replyGrid.ItemsSource = dt.DefaultView;
        }
    }
}
