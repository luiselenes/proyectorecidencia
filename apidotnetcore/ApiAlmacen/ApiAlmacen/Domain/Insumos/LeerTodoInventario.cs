using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiAlmacen.Domain.Insumos
{
    public class LeerTodoInventario : IRequest<List<InventarioIndexModel>> {
        
    }
 
        public class InventarioIndexModel
        {

            public string nombreinsumo { set; get; }
            public float Cantidad { get; set; }
            public float PrecioUnitario { get; set; }
            public float Importe { get; set; }
            public string Partida { get; set; }
        
    }
    //IRequestHandler >  peticion  ,  respuesta
    public class LeerTodoInventarioHandler : IRequestHandler<LeerTodoInventario,List<InventarioIndexModel>>
    {
        public LeerTodoInventarioHandler()
        {

        }
        public  async Task<List<InventarioIndexModel>> Handle (LeerTodoInventario request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

  
}

