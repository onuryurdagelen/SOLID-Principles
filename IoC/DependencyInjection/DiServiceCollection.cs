using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DependencyInjection
{
    public class DiServiceCollection
    {
        private List<ServiceDescriptor> _serviceDescriptor = new List<ServiceDescriptor>();
        public void RegisterSingleton<TService>()
        {
            _serviceDescriptor.Add(new ServiceDescriptor(typeof(TService), ServiceLifeTime.Singleton));

        } 
        public void RegisterSingleton<TService>(TService implementation)
        {
            _serviceDescriptor.Add(new ServiceDescriptor(implementation,ServiceLifeTime.Singleton));
        }
        public void RegisterTransient<TService>()
        {
            _serviceDescriptor.Add(new ServiceDescriptor(typeof(TService), ServiceLifeTime.Transient));

        }
        public void RegisterSingleton<TService, TImplementation>()
           where TImplementation : TService
        {
            _serviceDescriptor.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifeTime.Singleton));

        }
        public void RegisterTransient<TService,TImplementation>()
            where TImplementation:TService
        {
            _serviceDescriptor.Add(new ServiceDescriptor(typeof(TService),typeof(TImplementation), ServiceLifeTime.Transient));

        }
        public DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptor);
        }
    }
}
