using ApiAlmacen.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlmacen
{
    public class AlamacenDbContext : DbContext, IAlamacenDbContext
    {
        public DbSet<Inventario> inventario { set; get; }
        public DbSet<Almacenes> almacenen { set; get; }
        public DbSet<Entradas> entradas { set; get; }
        public DbSet<Estructuras> estructuras { set; get; }
        public DbSet<Insumos> insumos { set; get; }
        public DbSet<Modulos> modulos { set; get; }
        public DbSet<Partidas> partidas { set; get; }
        public DbSet<Proveedores> proveedores { set; get; }
        public DbSet<Requisicion_Compras> requisicion_compras { set; get; }
        public DbSet<Requisiciones_Insumo> requisiciones_insumo { set; get; }
        public DbSet<Roles> roles { set; get; }
        public DbSet<Usuarios> usuarios { set; get; }

        public AlamacenDbContext(DbContextOptions<AlamacenDbContext> options) : base(options) { }
        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }

}
