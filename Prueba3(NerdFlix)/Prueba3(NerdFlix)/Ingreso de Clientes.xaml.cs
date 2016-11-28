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

    public partial class Ingreso_de_Usuario : Window
    {
        public Ingreso_de_Usuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            AccesoNegocio n = new AccesoNegocio();
            Usuario u = new  Usuario();
            
            u.rut = txtRut.Text.ToUpper().Trim();
            u.dv = txtDv.Text.ToUpper().Trim();
            u.direccion = txtDirec.Text.ToUpper().Trim();
            u.nombre = txtNombre.Text.ToUpper().Trim();
            u.apellido = txtApellido.Text.ToUpper().Trim();
            u.email = txtMail.Text.ToUpper().Trim();
            u.fecha_nacimiento = datePickerFechaN.Text.ToUpper().Trim();
            u.pass = txtPass.Text.ToUpper().Trim();
            u.fono = Convert.ToInt32(txtFono.Text.ToUpper().Trim());

            n.Insert(u);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AccesoNegocio n = new AccesoNegocio();
            dgUsuarios.ItemsSource = n.ObtenerEmpleados().Tables[0].DefaultView;
        }

        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {
            AccesoNegocio n = new AccesoNegocio();
            //dgUsuarios.ItemsSource = n.ObtenerEmpleados().Tables[0].DefaultView;
        }

        
    }
}
