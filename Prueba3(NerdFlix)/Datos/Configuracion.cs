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
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9GOTC0R\MSSQLSERVER1;Initial Catalog=nerdflix;Persist Security Info=True;User ID=sa;Password=Sa2016");

                return cn;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al conectar", ex);
            }
        }
    }
}
