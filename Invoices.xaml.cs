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

namespace SchoolBilling
{
    /// <summary>
    /// Interaction logic for Invoices.xaml
    /// </summary>
    public partial class Invoices : Window
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            //Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dashboard = new MainWindow();
            dashboard.Show();
            this.Close();
        }

        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            Students estudiantes = new Students();
            estudiantes.Show();
            this.Close();
        }

        private void btnInvoices_Click(object sender, RoutedEventArgs e)
        {
            Invoices billing = new Invoices();
            billing.Show();
            this.Close();
        }
    }
}
