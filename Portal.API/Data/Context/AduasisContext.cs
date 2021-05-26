using Microsoft.EntityFrameworkCore;
using Portal.API.EntityFramework.Models;
using Portal.API.Models;

#nullable disable

namespace Portal.API.Context
{
    public partial class AduasisContext : DbContext
    {
        public AduasisContext()
        {
        }

        public AduasisContext(DbContextOptions<AduasisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WebUsuario> WebUsuarios { get; set; }
        public virtual DbSet<OcVehiculo> OcVehiculo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebUsuario>().HasKey(u => new
            {
                u.IdAplicacion,
                u.Usuario
            });

            modelBuilder.Entity<OcVehiculo>().HasKey(u => new
            {
                u.IdAlmacen,
                u.IdTipoVehiculo,
                u.NumeroVehiculo,
                u.FechaArribo
            });


        }

    }
}
