using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace SchoolBilling
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


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=AOVALLE-PC\SQLEXPRESS;Initial Catalog=SchoolBill;Integrated Security=True;");
            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM [User] WHERE UserName=@UserName AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=AOVALLE-PC\SQLEXPRESS;Initial Catalog=SchoolBill;Integrated Security=True;");
                try
                {

                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    String query = "SELECT COUNT(1) FROM [User] WHERE UserName=@UserName AND Password=@Password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }
    }

}
