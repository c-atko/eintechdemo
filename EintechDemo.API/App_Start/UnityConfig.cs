using EintechDemo.API.Controllers;
using EintechDemo.API.Data;
using EintechDemo.API.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EintechDemo.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType(typeof(IPersonRepository), typeof(PersonRepository));
            container.RegisterType(typeof(IEintechDemoContext), typeof(EintechDemoContext));
            //container.RegisterType<IPersonRepository, PersonRepository>();
            //container.RegisterType<IEintechDemoContext, EintechDemoContext>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}