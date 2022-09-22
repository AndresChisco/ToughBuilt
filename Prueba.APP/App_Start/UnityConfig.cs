using Prueba.BLL.Implementatios;
using Prueba.BLL.Interfaces;
using Prueba.DAL.Implementations;
using Prueba.DAL.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;
using AutoMapper;
using Prueba.APP.Automapper;
using Unity.Injection;
using System;

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

            //Mapper
            var mapperConfig = MapperHelper.InitializeAutoMapper();
            var mapper = mapperConfig.CreateMapper();
            container.RegisterType<IMapper, Mapper>(new InjectionConstructor(mapperConfig));
            //container.RegisterInstance(mapper, Activator.CreateInstance<T>());
            //container.RegisterType<IMapper, Mapper>();

            //Business
            container.RegisterType<IProductBL, ProductBL>();

            //Data
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>), new TransientLifetimeManager());
        }
    }
}