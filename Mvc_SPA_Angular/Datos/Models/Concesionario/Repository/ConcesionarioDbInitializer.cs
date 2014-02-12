using System.Data.Entity;
using System.Data.Objects.DataClasses;
using Datos.Models.Concesionario.Entities;

namespace Datos.Models.Concesionario.Repository
{
    public class ConcesionarioDbInitializer : CreateDatabaseIfNotExists<ConcesionarioContext>
    {
        protected override void Seed(ConcesionarioContext dbContext)
        {
            dbContext.Concesionarios.Add(new ConcesionarioEntity
            {
                IdConcesionario = 1,
                Marca = "Audi",
                Nombre = "Casa Benito",
                Coches = new EntityCollection<CocheEntity>
                        {
                            new CocheEntity
                                {
                                    IdCoche = 11,
                                    Marca = "Audi",
                                    Modelo = "A1",
                                    Precio = 18000.00,
                                    Fecha = "2009",
                                    Foto = "../Content/Images/A1.jpg",
                                    Descripcion = "Muy buen estado"
                                },
                            new CocheEntity
                                {
                                    IdCoche = 11,
                                    Marca = "Audi",
                                    Modelo = "A3",
                                    Precio = 30000.00,
                                    Fecha = "2011",
                                    Foto = "../Content/Images/A3.jpg",
                                    Descripcion = "Siempre en garaje"
                                }
                        }
            });

            dbContext.Concesionarios.Add(new ConcesionarioEntity
            {
                IdConcesionario = 1,
                Marca = "BMW",
                Nombre = "Barcelona Auto",
                Coches = new EntityCollection<CocheEntity>
                        {
                            new CocheEntity
                                {
                                    IdCoche = 11,
                                    Marca = "BMW",
                                    Modelo = "S1",
                                    Precio = 18000.00,
                                    Fecha = "2010",
                                    Foto = "../Content/Images/S1.jpg",
                                    Descripcion = "Muy buen estado"
                                },
                            new CocheEntity
                                {
                                    IdCoche = 11,
                                    Marca = "BMW",
                                    Modelo = "S3",
                                    Precio = 30000.00,
                                    Fecha = "2012",
                                    Foto = "../Content/Images/S3.jpg",
                                    Descripcion = "Kilometro 0"
                                }
                        }
            });

            dbContext.SaveChanges();
        }
    }
}