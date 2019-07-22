using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace OnionAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new Microsoft.Practices.Unity.UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}