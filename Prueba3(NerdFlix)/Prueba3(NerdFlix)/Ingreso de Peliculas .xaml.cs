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
using System.Data;



namespace Prueba3_NerdFlix_
{
   
    public partial class Ingreso_de_Peliculas : Window
    {
        public Ingreso_de_Peliculas()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            string valor = comboBoxGenero.SelectedValue.ToString();
            //AccesoNegocio n = new AccesoNegocio();
            //Pelicula p = new Pelicula();

            //p.titulo = textNombrePelicula.Text.ToUpper().Trim();
            //p.año = Convert.ToInt32(textAño.Text.Trim());
            //p.duracion = Convert.ToInt32(textDuracion.Text.ToUpper().Trim());
            //p.genero = Convert.ToInt32(comboBoxGenero.Text.ToUpper().Trim());
            //p.cantidad = Convert.ToInt32(textStock.Text.ToUpper().Trim());
            //p.valor = Convert.ToInt32(textPrecio.Text.ToUpper().Trim());



            //n.InsertPeliculas(p);
        }
        
         //String strCadena = CadenaConexion();
         //    SqlConnection conn = new SqlConnection(strCadena);

         //    SqlDataAdapter dataAdapter = new SqlDataAdapter("listadorusuario", conn);
         //    DataSet dsSp = new DataSet();
         //    try
         //    {

         //        dataAdapter.Fill(dsSp);

         //        comboBox2.DisplayMemberPath = "rut_usuario";
         //        comboBox2.SelectedValuePath = "nom_usuario";
         //        comboBox2.ItemsSource = dsSp.Tables[0].DefaultView;
         //        conn.Close();
         //    }

         //    catch (Exception exc)
         //    {
         //        MessageBox.Show(exc.Message);
         //    }
        private void CargaBox(){

            AccesoNegocio n = new AccesoNegocio();
            //comboBoxGenero.ItemsSource = n.GeneroPeliculas().Tables[0].DefaultView;
            comboBoxGenero.DataContext = n.ListarGeneros();
            //comboBoxGenero.DisplayMemberPath = n.ListarGeneros().Columns[1].ToString();
            comboBoxGenero.DisplayMemberPath = "Nombre";
            comboBoxGenero.SelectedValuePath = "Codigo";
            
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargaBox();
        }
    }
}
