using System.Collections.Generic;
using System.Linq;
using Datos.Models.Concesionario.Repository;
using Datos.Models.Contracts;

namespace Datos.Models.Concesionario.Services
{
    public class ConcesionarioService : IConcesionarioService
    {
        private readonly ConcesionarioContext _dbContext;

        public ConcesionarioService(ConcesionarioContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<string> GetProvincias()
        {
            var elements = _dbContext.Provincias.OrderBy(x => x.Nombre);

            return (elements.Any()) ? elements.ToList().Select(c=> c.Nombre):new List<string>() ;
        }

        public IEnumerable<Datos.Models.Contracts.Concesionario> GetAll()
        {
            var elements = _dbContext.Concesionarios.OrderBy(x => x.Marca);

            return (elements.Any()) ? elements.ToList().Select(c => c.ToDto()) : new List<Datos.Models.Contracts.Concesionario>();
        }

        public Datos.Models.Contracts.Concesionario GetById(int id)
        {
            var element = _dbContext.Concesionarios.FirstOrDefault(x => x.IdConcesionario == id);
            return (element != null) ? element.ToDto() : new Datos.Models.Contracts.Concesionario();
        }

        public Coche GetCocheDetail(int id)
        {
            var element = _dbContext.Coches.FirstOrDefault(c => c.IdCoche == id);
            return (element != null) ? element.ToDto() : new Coche();
        }

        public void EditCoche(Coche coche)
        {
            if (coche != null)
            {
                var elemet = _dbContext.Coches.FirstOrDefault(c => c.IdCoche == coche.IdCoche);
                if (elemet != null)
                {
                    elemet.Precio = coche.Precio;
                    elemet.Modelo = coche.Modelo;
                    elemet.Marca = coche.Marca;

                    _dbContext.SaveChanges();
                }

            }


        }
    }
}