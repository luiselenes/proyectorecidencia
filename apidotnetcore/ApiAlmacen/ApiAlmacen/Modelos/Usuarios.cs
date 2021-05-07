using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen.Modelos
{
    public class Usuarios
    {
        public int id_usurio { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int id_rol { set; get; }
        public DateTime ultima_entrada { set; get; }
    } 
}
