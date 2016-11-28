using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba3_NerdFlix_.Clases
{
    public class Pelicula
    {
        String titulo;
        String año;
        int Duracion;
        String genero;
        int valor;


        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
       

        public String Año
        {
            get { return año; }
            set { año = value; }
        }

       

        public int duracion
        {
            get { return Duracion; }
            set { Duracion = value; }
        }


        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }

       
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    
    
    
    }

      


}
