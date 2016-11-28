using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prueba3_NerdFlix_
{
    /// <summary>
    /// Lógica de interacción para MenuUsuario.xaml
    /// </summary>
    public partial class MenuUsuario : Window
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            CompraClientes frm6 = new CompraClientes();
            frm6.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MisPelis frm = new MisPelis();
            this.Show();
        }
    }
}
