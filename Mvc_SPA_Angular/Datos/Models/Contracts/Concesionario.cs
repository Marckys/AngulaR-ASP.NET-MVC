using System.Collections.Generic;

namespace Datos.Models.Contracts
{
    public class Concesionario : IConcesionario
    {
        public int IdConcesionario { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public IEnumerable<Coche> Coches { get; set; }
    }
}