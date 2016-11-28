using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba3_NerdFlix_.Clases
{
    class Usuario
    {


        String Rut;
        String Dv;
        String Nombre;
        String apellido;
        String fechaNacimiento;
        String Direccion;
        int Fono;
        String email;
        string pass;


        public String rut
        {
            get { return Rut; }
            set { Rut = value; }
        }
        public String dv
        {
            get { return Dv; }
            set { Dv = value; }
        }
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public String FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public String direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public int fono
        {
            get { return Fono; }
            set { Fono = value; }
        }

      
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

               

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

    }
}
