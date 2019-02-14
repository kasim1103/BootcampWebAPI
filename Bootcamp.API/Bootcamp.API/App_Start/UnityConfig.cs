using BusinessLogic.Services;
using BusinessLogic.Services.Master;
using Common.Interfaces;
using Common.Interfaces.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Bootcamp.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // this is Repository Area
            container.RegisterType<ISupplierService, SupplierService>();

            // this is Repository Area
            container.RegisterType<ISupplierRepository, SupplierRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}