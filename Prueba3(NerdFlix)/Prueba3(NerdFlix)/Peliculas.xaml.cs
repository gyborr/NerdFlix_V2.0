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
namespace Prueba3_NerdFlix_
{
    /// <summary>
    /// Lógica de interacción para Peliculas.xaml
    /// </summary>
    public partial class Peliculas : Window
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AccesoNegocio n = new AccesoNegocio();

            dg.ItemsSource = n.ObtenerPeliculas().Tables[0].DefaultView;
        }

       
    }
}
