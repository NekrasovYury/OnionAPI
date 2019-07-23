using Infastructure.Interface;
using InfastructureService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace DI.Models
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDataRepository, FakeDataRepositories>(new ContainerControlledLifetimeManager());
        }
    }
}
