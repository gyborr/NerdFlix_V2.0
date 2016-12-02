using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Venta
    {
        public string direccion_venta { get; set; }
        public string medio_pago { get; set; }
        public string numero_tarjeta { get; set; }
        public string fecha_venta { get; set; }
        public int cantidad { get; set; }
    }
}
