using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen
{
    public class AlamacenDbContext
    {
        public class insumo
        {

            public int id_insumo { get; set; }
            public string descripcion { get; set; }
            public int id_tipo_insumo { get; set; }
            public float costo_unitario { get; set; }
            public string unidad_medidaint { get; set; }
        }

    }
  
}
