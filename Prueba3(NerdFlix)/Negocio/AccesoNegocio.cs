using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Clases;
using System.Data;


namespace Negocio
{
    public class AccesoNegocio
    {

        public int Insert(Usuario u)
        {
            return new AccesoDatos().Insert(u);
        }
        //public int Insert(string rut, string dv, string Direccion ,string Nombre, string Apellido, string email, string fechaNacimiento, string pass, int telefono)
        //{
        //    return new AccesoDatos().Insert(rut,dv,Direccion,Nombre,Apellido,email,fechaNacimiento,pass,telefono);
        //}
        public DataSet ObtenerEmpleados()
        {
            return new AccesoDatos().ObtenerEmpleados();
        }


        public int Insert(Pelicula p)
        {
            return new AccesoDatos().Insert(p);
        }
        //public int Insert(Venta v)
        //{
        //    return new AccesoDatos().Insert(v);
        //}


        public DataSet ObtenerPeliculas()
        {
            return new AccesoDatos().ObtenerPeliculas();
        }
        public DataSet GeneroPeliculas()
        {
            return new AccesoDatos().GeneroPeliculas();
        }



        


    }


}
