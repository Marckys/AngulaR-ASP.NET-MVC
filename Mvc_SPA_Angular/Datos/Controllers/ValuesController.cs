using System.Collections.Generic;
using System.Web.Http;
using Datos.Models.Concesionario.Services;
using Datos.Models.Contracts;

namespace Datos.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IConcesionarioService _concesionarioService;

        public ValuesController(IConcesionarioService concesionarioService)
        {
            _concesionarioService = concesionarioService;
        }


        // GET api/values
        public IEnumerable<Concesionario> Get()
        {
            return _concesionarioService.GetAll();
        }

        // GET api/values/5
        public Coche Get(int id)
        {
            return _concesionarioService.GetCocheDetail(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            var d = "";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Coche coche)
        {
            coche.IdCoche = id;
            _concesionarioService.EditCoche(coche);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
