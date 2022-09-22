using Prueba.BLL.Implementatios;
using Prueba.BLL.Interfaces;
using Prueba.DAL.Implementations;
using Prueba.DAL.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace Prueba.APP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //Business
            container.RegisterType<IProductBL, ProductBL>();

            //Data
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>), new TransientLifetimeManager());
        }
    }
}