using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmacen
{
    public class AlamacenDbContext : DbContext
    {
        public class insumo
        {

            public int id_insumo { get; set; }
            public string descripcion { get; set; }
            public int id_tipo_insumo { get; set; }
            public float costo_unitario { get; set; }
            public string unidad_medidaint { get; set; }
        }


        public DbSet<Server> Servers { get; set; }
        public AlamacenDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;port=3306;Connect Timeout=5;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }

        public class Server
        {
            public ulong Id { get; set; }
            public string Prefix { get; set; }
        }



    }
  
}
