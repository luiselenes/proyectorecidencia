using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen.Modelos
{
    public class Entradas
    {
        public int id_entrada { set; get; }
        public int id_almacen { set; get; }
        public int id_insumo { set; get; }
        public int id_proveedor { set; get; }
        public int id_compra { set; get; }
        public DateTime fecha_entrada { set; get; }
        public float cantidad { set; get; }
        public float importe { set; get; }
        

    }
}

  