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

namespace CardinalThesisExchange
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP (1) uid, name, email, interest, course FROM UserTable ORDER BY datetime DESC", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    uid_tbox.Text = dr.GetValue(0).ToString();
                    fullName_tbox.Text = dr.GetValue(1).ToString();
                    email_tbox.Text = dr.GetValue(2).ToString();
                    interest_tbox.Text = dr.GetValue(3).ToString();
                    course_tbox.Text = dr.GetValue(4).ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserTable set name=@name, interest=@interest, course=@course WHERE uid=@uid", cn);
            cmd.Parameters.AddWithValue("@uid", int.Parse(uid_tbox.Text));
            cmd.Parameters.AddWithValue("@name", fullName_tbox.Text);
            cmd.Parameters.AddWithValue("@interest", interest_tbox.Text);
            cmd.Parameters.AddWithValue("@course", course_tbox.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Profile successfully updated!", "Noice", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
