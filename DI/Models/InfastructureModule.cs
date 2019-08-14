using Infastructure.Interface;
using InfastructureService.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using System.Configuration;
using Users.InfrastructureServices.Configurations;
using Users.InfrastructureServices.Contexts;

namespace DI.Models
{
    public class InfrastructureModule : IModule
    {

        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();

            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));
            container.RegisterType<IDataRepository, FakeDataRepositories>(new ContainerControlledLifetimeManager());
        }
    }
}
