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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolBilling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
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


        private void btnStudents_Click_1(object sender, RoutedEventArgs e)
        {
            Students estudiantes = new Students();
            estudiantes.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainWindow dashboard = new MainWindow();
            dashboard.Show();
            this.Close();
        }

        private void btnInvoices_Click(object sender, RoutedEventArgs e)
        {
            Invoices billing = new Invoices();
            billing.Show();
            this.Close();
        }
    }

    internal class ConsumoViewModel
    {
        public List<Consumo> Consumo { get; private set; }

        public ConsumoViewModel(Consumo consumo)
        {
            Consumo = new List<Consumo>();
            Consumo.Add(consumo);
        }
    }

    internal class Consumo
    {
        public string Titulo { get; private set; }
        public int Porcentagem { get; private set; }

        public Consumo()
        {
            Titulo = "Recaudaciones de este mes";
            Porcentagem = CalcularPorcentagem();
        }

        private int CalcularPorcentagem()
        {
            return 85; //Calculo da porcentagem de consumo
        }
    }
}
