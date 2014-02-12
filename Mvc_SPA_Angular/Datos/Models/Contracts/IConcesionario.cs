using System.Collections.Generic;

namespace Datos.Models.Contracts
{
    public interface IConcesionario
    {
        int IdConcesionario { get; set; }
        string Nombre { get; set; }
        string Marca { get; set; }
        IEnumerable<Coche> Coches { get; set; }
    }
}