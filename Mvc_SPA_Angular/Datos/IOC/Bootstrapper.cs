using System.Data.Entity;
using System.Web.Http;
using Datos.Models.Concesionario.Repository;
using Datos.Models.Concesionario.Services;
using Microsoft.Practices.Unity;

namespace Datos.IOC
{
    public class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            container.RegisterType<IConcesionarioService, ConcesionarioService>();
            container.RegisterType<DbContext, ConcesionarioContext>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}