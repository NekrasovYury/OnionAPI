using System.Web.Http;
using DI;
using DI.Models;

using Unity.WebApi;
using Microsoft.Practices.Unity;
//using Unity;

namespace OnionAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // –егистрируем модуль DomainModule в рамках контейнера container
            Register<DomainModule>(container);
            Register<InfrastructureModule>(container);

            // ”станавливаем dependency-resolver дл€ нашего приложени€, к оторый будет использоватьс€ дл€
            // резолвинга зависимостей использу€ container
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            // »нициализируем экземпл€р модул€ и вызываем метод Register, передава€ целевой container 
            // дл€ регистрации зависимостей
            new T().Register(container);
        }
    }
}