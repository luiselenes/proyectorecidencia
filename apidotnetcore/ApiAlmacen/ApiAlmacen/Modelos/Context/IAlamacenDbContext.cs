using ApiAlmacen.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApiAlmacen
{
    public interface IAlamacenDbContext
    {
        DbSet<Almacenes> almacenen { get; set; }
        DbSet<Entradas> entradas { get; set; }
        DbSet<Estructuras> estructuras { get; set; }
        DbSet<Insumos> insumos { get; set; }
        DbSet<Inventario> inventario { get; set; }
        DbSet<Modulos> modulos { get; set; }
        DbSet<Partidas> partidas { get; set; }
        DbSet<Proveedores> proveedores { get; set; }
        DbSet<Requisicion_Compras> requisicion_compras { get; set; }
        DbSet<Requisiciones_Insumo> requisiciones_insumo { get; set; }
        DbSet<Roles> roles { get; set; }
        DbSet<Usuarios> usuarios { get; set; }

        Task<int> SaveChanges();
    }
}