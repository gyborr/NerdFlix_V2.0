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
using Negocio;
using Clases;

namespace NerdFlix
{
    /// <summary>
    /// Lógica de interacción para MostrarClientes.xaml
    /// </summary>
    public partial class MostrarClientes : Window
    {
        public MostrarClientes()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            AccesoNegocio n = new AccesoNegocio();
            dgClientes.ItemsSource = n.ObtenerEmpleados().Tables[0].DefaultView;
        }
    }
}
