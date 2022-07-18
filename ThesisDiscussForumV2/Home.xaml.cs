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

namespace ThesisDiscussForumV2
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {

        System.Data.SqlClient.SqlConnection cn;

        public Home()
        {
            InitializeComponent();
        }

        private void Logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have successfully logged out. ", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4Q2122\CPE106\WPF\ThesisDiscussForumV2\TDF_Database.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
