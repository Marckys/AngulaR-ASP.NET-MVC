
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class ConcesionariosController : Controller
    {
        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult List()
        {
            return PartialView();
        }
        public ActionResult Detail()
        {
            return PartialView();
        }

        public ActionResult Edit()
        {
            return PartialView();
        }
        public ActionResult Progress()
        {
            return PartialView();
        }

    }
}
