using System.Collections.Generic;
using System.Web.Http;
using Datos.Models.Concesionario.Services;

namespace Datos.Controllers
{
    public class MaestrosController : ApiController
    {

       private readonly IConcesionarioService _concesionarioService;

       public MaestrosController(IConcesionarioService concesionarioService)
        {
            _concesionarioService = concesionarioService;
        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return _concesionarioService.GetProvincias();
        }
    }
}
