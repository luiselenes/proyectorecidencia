using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen.Modelos
{
    public class Inventario
    {
        public int id_insumo { set; get; }
        public int id_entrada { set; get; }
        public float cantidad { set; get; }
    }
}
