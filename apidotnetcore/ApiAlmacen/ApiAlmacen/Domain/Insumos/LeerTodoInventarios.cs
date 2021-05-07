using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiAlmacen.Domain.Insumos
{
    public class LeerTodoInventarios : IRequest<List<InventarioIndexModel>> {
        
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
    public class LeerTodoInventarioHandler : IRequestHandler<LeerTodoInventarios,List<InventarioIndexModel>>
    {
        public LeerTodoInventarioHandler()
        {

        }
        public  async Task<List<InventarioIndexModel>> Handle (LeerTodoInventarios request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    //-----------------------------------------------------------------------------
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
        {
            private readonly IApplicationContext _context;
            public GetAllProductsQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
            {
                var productList = await _context.Products.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList.AsReadOnly();
            }
        }
    }
}

