using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get;  }
        public Type _ImplementationType { get; }
        public object Implementation { get; internal set; }

        public ServiceLifeTime LifeTime { get; }

        public ServiceDescriptor(object implementation,ServiceLifeTime serviceLifeTime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            LifeTime = serviceLifeTime;
        }
        public ServiceDescriptor(Type serviceType, ServiceLifeTime serviceLifeTime)
        {
            ServiceType = serviceType;
            LifeTime = serviceLifeTime;
        }
        public ServiceDescriptor(Type serviceType,Type ImplementationType, ServiceLifeTime serviceLifeTime)
        {
            ServiceType = serviceType;
            _ImplementationType = ImplementationType;
            LifeTime = serviceLifeTime;
        }
    }
}
