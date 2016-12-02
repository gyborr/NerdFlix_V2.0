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

namespace NerdFlix
{
    /// <summary>
    /// Lógica de interacción para MenuAdministrador.xaml
    /// </summary>
    public partial class MenuAdministrador : Window
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btn_ingresoCliente_Click(object sender, RoutedEventArgs e)
        {
            IngresoClientes fr = new IngresoClientes();
            fr.Show();

        }

        private void btn_IngresoPeli_Click(object sender, RoutedEventArgs e)
        {
            IngresoPeliculas fr = new IngresoPeliculas();
            fr.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MostrarClientes fr = new MostrarClientes();
            fr.Show();
        }
    }
}
