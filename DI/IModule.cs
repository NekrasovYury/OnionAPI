using Microsoft.Practices.Unity;

namespace DI
{
    public interface IModule
    {
        void Register(IUnityContainer container);
        
    }
}
