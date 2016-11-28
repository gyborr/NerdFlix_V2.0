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
    /// Lógica de interacción para CompraClientes.xaml
    /// </summary>
    public partial class CompraClientes : Window
    {
        public CompraClientes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
