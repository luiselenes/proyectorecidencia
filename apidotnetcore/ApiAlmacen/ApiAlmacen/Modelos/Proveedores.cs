using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen.Modelos
{
    public class Proveedores
    {
        public int id_provedor { set; get; }
        public string nombre { set; get; }
        public string rfc { set; get; }
        public string direccion { set; get; }
    }
}