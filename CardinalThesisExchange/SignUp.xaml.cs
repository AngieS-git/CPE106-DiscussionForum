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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Signup_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=GINO-DESKTOP\SQLEXPRESS;Initial Catalog=CTE_Database;Integrated Security=True");
            cn.Open();
            try
            {
                if (fullname_tbox.Text != string.Empty || email_tbox.Text != string.Empty || password_tbox.Password != string.Empty)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable WHERE email='" + email_tbox.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Email Address already taken, Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("INSERT INTO UserTable VALUES(@name,@email,@password,DEFAULT,DEFAULT,@datetime)", cn);
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", fullname_tbox.Text);
                        cmd.Parameters.AddWithValue("@email", email_tbox.Text);
                        cmd.Parameters.AddWithValue("@password", password_tbox.Password);
                        cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Account created successfully. Please login.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter information in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
