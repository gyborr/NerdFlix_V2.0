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
                SqlConnection cn = new SqlConnection(@"Data Source=JOSE;Initial Catalog=nerdflix;Persist Security Info=True;User ID=sa;Password=sa");

                return cn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al conectar", ex);
            }
        }
    }
}
