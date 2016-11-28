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
    /// Lógica de interacción para MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Ingreso_de_Peliculas frm = new Ingreso_de_Peliculas();
            frm.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Ingreso_de_Usuario frm2 = new Ingreso_de_Usuario();
            frm2.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Inventario frm3 = new Inventario();
            frm3.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
