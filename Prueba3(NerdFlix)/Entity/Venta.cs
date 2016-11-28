using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba3_NerdFlix_.Clases
{
    class Venta
    {

        String direccion_venta;
        String medio_pago;
        String numero_tarjeta;
        String fecha_venta;
        int cantidad;

       

        public String Direccion_venta
        {
            get { return direccion_venta; }
            set { direccion_venta = value; }
        }
        
        public String Medio_pago
        {
            get { return medio_pago; }
            set { medio_pago = value; }
        }

        

        public String Numero_tarjeta
        {
            get { return numero_tarjeta; }
            set { numero_tarjeta = value; }
        }

       

        public String Fecha_venta
        {
            get { return fecha_venta; }
            set { fecha_venta = value; }
        }

       
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }

}
