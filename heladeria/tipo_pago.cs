using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heladeria
{
    public class tipo_pago
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }

        public tipo_pago() { }

        public tipo_pago(String codigo,String nombre,String descripcion) {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
