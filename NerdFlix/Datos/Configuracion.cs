using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Configuracion
    {

        public static SqlConnection getConexion()
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=MDA-PC\SQLEXPRESS;Initial Catalog=nerdflixx;Integrated Security = True");
                //SqlConnection cn = new SqlConnection("Data Source=JOSE;Initial Catalog=nerdflix;Integrated Security = True");
                
                return cn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al conectar", ex);
            }
        }
    }
}
