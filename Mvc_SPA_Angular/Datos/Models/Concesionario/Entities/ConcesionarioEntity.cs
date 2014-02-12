using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Datos.Models.Contracts;

namespace Datos.Models.Concesionario.Entities
{
    public class ConcesionarioEntity
    {
        [Key]
        public int IdConcesionario { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public virtual ICollection<CocheEntity> Coches { get; set; }


        public Contracts.Concesionario ToDto()
        {
            return new Contracts.Concesionario
            {
                IdConcesionario = IdConcesionario,
                Marca = Marca,
                Nombre = Nombre,
                Coches = CochesToDto()
            };
        }

        private IEnumerable<Coche> CochesToDto()
        {
            return (Coches != null) ? Coches.Select(coche => coche.ToDto()).ToList() : null;
        }
    }
}