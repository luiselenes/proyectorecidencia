namespace ApiAlmacen.Domain.Insumos
{
    public class LeerTodoInventarioHandlerBase
    {
        public  Task<List<InventarioIndexModel>> Handle(LeerTodoInventario request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}