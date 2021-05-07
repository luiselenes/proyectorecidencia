using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen.Modelos
{
    public class Requisicion_Compras
    {
        public int  id_compra { set; get; }
    
    public int id_insumo { set; get; }
    public DateTime fecha { set; get; } 
    public float cantidad { set; get; }
    public string comprador { set; get; }
    public int numero { set; get; }
    public string solicitante{ set; get; }
    public string revisor  { set; get; }
    public string autorizante{ set; get; }
    public string observaciones { set; get; }
    public string centro_costo { set; get; }
    public string prioridad { set; get; }
    public string unidad{ set; get; }

    }
}


