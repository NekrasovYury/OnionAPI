using Domain.Interface;
using DomainService.DomainService;
using Infastructure.Interface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Models
{
    public class DomainModule : IModule
    {
     

        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDataInterface, DataService>(new HierarchicalLifetimeManager());
        }
    }
}
