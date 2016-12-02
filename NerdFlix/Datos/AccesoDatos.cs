using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Datos;
using Clases;
using System.Data;
namespace Datos
{
    public class AccesoDatos
    {
        SqlConnection cn = Configuracion.getConexion();

        public int Insert(Usuario u)
        {

            SqlCommand _comando = new SqlCommand("ingresa_persona", cn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@rut", SqlDbType.VarChar).Value = u.rut;
            _comando.Parameters.Add("@dv", SqlDbType.VarChar).Value = u.dv;
            _comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = u.direccion;
            _comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.nombre;
            _comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = u.apellido;
            _comando.Parameters.Add("@email", SqlDbType.VarChar).Value = u.email;
            _comando.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar).Value = u.fecha_nacimiento;
            _comando.Parameters.Add("@pass", SqlDbType.VarChar).Value = u.pass;
            _comando.Parameters.Add("@telefono", SqlDbType.Int).Value = u.fono;

            try
            {
                cn.Open();
                return _comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
                _comando.Dispose();
            }
        }
        public int InsertPelicula(Pelicula p)
        {

            SqlCommand _comando = new SqlCommand("ingresa_pelicula", cn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = p.titulo;
            _comando.Parameters.Add("@año", SqlDbType.Int).Value = p.año;
            _comando.Parameters.Add("@duracion", SqlDbType.Int).Value = p.duracion;
            _comando.Parameters.Add("@cod_genero", SqlDbType.Int).Value = p.genero;
            _comando.Parameters.Add("@stock", SqlDbType.Int).Value = p.stock;
            _comando.Parameters.Add("@precio", SqlDbType.Int).Value = p.precio;


            try
            {
                cn.Open();
                return _comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
                _comando.Dispose();
            }
        }
        //public int Insert(Venta v)
        //{

        //    SqlCommand _comando = new SqlCommand("ingresa_persona", cn);
        //    _comando.CommandType = CommandType.StoredProcedure;
        //    _comando.Parameters.Add("@rut", SqlDbType.VarChar).Value = u.rut;
        //    _comando.Parameters.Add("@dv", SqlDbType.VarChar).Value = u.dv;
        //    _comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = u.direccion;
        //    _comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.nombre;
        //    _comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = u.apellido;
        //    _comando.Parameters.Add("@email", SqlDbType.VarChar).Value = u.email;
        //    _comando.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar).Value = u.fecha_nacimiento;
        //    _comando.Parameters.Add("@pass", SqlDbType.VarChar).Value = u.pass;
        //    _comando.Parameters.Add("@telefono", SqlDbType.Int).Value = u.fono;

        //    try
        //    {
        //        cn.Open();
        //        return _comando.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //        _comando.Dispose();
        //    }
        //}
        public DataSet ObtenerEmpleados()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand _comando = new SqlCommand("SELECT * FROM persona", cn);

                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(ds);

                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ListaUsuario(string NombreLike)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand _comando = new SqlCommand("ListaDatos", cn);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet ObtenerPeliculas()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand _comando = new SqlCommand("SELECT * FROM pelicula", cn);

                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(ds);

                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet ListaPelicula(string NombrePelicula)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand _comando = new SqlCommand("listar_combo_pelicula", cn);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet GeneroPeliculas()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand _comando = new SqlCommand("ObtieneGenero", cn);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(ds);

                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarGeneros()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand _comando = new SqlCommand("ObtieneGenero", cn);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(_comando);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
