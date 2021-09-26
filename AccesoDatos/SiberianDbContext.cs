using Microsoft.EntityFrameworkCore;
using AccesoDatos.Entidades;

namespace AccesoDatos
{
    public class SiberianDbContext : DbContext
    {
        public SiberianDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CiudadEntity> Ciudades { get; set; }
        public DbSet<RestauranteEntity> Restaurantes { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<CiudadEntity>().ToTable("Ciudad");
            model.Entity<RestauranteEntity>().ToTable("Restaurante");
            model.Entity<RestauranteEntity>().ToTable("Restaurante");
        }
    }
}
