using System.Web.Http;
using DI;
using DI.Models;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace OnionAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // ������������ ������ DomainModule � ������ ���������� container
            Register<DomainModule>(container);
            Register<InfrastructureModule>(container);

            // ������������� dependency-resolver ��� ������ ����������, � ������ ����� �������������� ���
            // ���������� ������������ ��������� container
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            // �������������� ��������� ������ � �������� ����� Register, ��������� ������� container 
            // ��� ����������� ������������
            new T().Register(container);
        }
    }
}