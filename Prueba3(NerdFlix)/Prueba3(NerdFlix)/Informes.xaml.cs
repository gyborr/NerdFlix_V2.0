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
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_IngresoPelis(object sender, RoutedEventArgs e)
        {
            Ingreso_de_Peliculas frm1 = new Ingreso_de_Peliculas();
            frm1.Show();

           

        }

        

        private void MenuItem_Click_IngresoClientes(object sender, RoutedEventArgs e)
        {
            Ingreso_de_Usuario frm2 = new Ingreso_de_Usuario();
            frm2.Show();
        }

        private void MenuItem_Click_ListarPelis(object sender, RoutedEventArgs e)
        {
            Peliculas frm3 = new Peliculas();
            frm3.Show();
        }

        private void MenuItem_Click_ListarUsu(object sender, RoutedEventArgs e)
        {
            Clientes frm4 = new Clientes();
            frm4.Show();
        }
    }
}
