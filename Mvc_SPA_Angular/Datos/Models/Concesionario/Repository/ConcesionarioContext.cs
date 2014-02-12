using System.Data.Entity;
using Datos.Models.Concesionario.Entities;

namespace Datos.Models.Concesionario.Repository
{
    public class ConcesionarioContext : DbContext
    {
        public DbSet<ConcesionarioEntity> Concesionarios { get; set; }
        public DbSet<CocheEntity> Coches { get; set; }
        public DbSet<ProvinciaEntity> Provincias { get; set; }
    }
}