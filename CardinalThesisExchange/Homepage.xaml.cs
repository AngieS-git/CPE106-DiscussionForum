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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT title, date, owner, post FROM PostTable ORDER BY date DESC", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            datagrid.ItemsSource = dt.DefaultView;
        }

        private void Profile_btn_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void Logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have logged out.", "Bye-Bye!", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            CreatePost createPost = new CreatePost();
            createPost.Show();
        }

        private void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT title, date, owner, post FROM PostTable ORDER BY date DESC", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            cn.Close();
            datagrid.ItemsSource = dt.DefaultView;
        }

        private void Viewpost_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)((Button)e.Source).DataContext;
                ViewPost viewPost = new ViewPost();
                viewPost.title_lbl.Content = drv[0].ToString();
                viewPost.owner_lbl.Content = drv[2].ToString();
                viewPost.post_lbl.Content = drv[3].ToString();
                viewPost.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PostTable WHERE title LIKE '" + search_tbox.Text + "%' OR owner LIKE '" + search_tbox.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.ItemsSource = dt.DefaultView;
            cn.Close();
        }
    }
}
