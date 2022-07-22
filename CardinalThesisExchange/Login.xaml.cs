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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            try
            {
                if (email_tbox.Text != string.Empty || password_tbox.Password != string.Empty)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable WHERE email='" + email_tbox.Text + "' and password='" + password_tbox.Password + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd = new SqlCommand("UPDATE UserTable SET datetime=@datetime WHERE email='" + email_tbox.Text + "'", cn);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        this.Close();
                        Profile profile = new Profile();
                        Homepage homepage = new Homepage();
                        homepage.Show();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Account does not exist or incorrect input.", "Account what?", MessageBoxButton.OK, MessageBoxImage.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete or no input in the textboxes.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
