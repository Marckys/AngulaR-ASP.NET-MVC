using System.Collections.Generic;
using Datos.Models.Contracts;

namespace Datos.Models.Concesionario.Services
{
    public interface IConcesionarioService
    {
        IEnumerable<Datos.Models.Contracts.Concesionario> GetAll();
        Datos.Models.Contracts.Concesionario GetById(int id);
        Coche GetCocheDetail(int id);
        void EditCoche(Coche coche);
        IEnumerable<string> GetProvincias();
    }
}