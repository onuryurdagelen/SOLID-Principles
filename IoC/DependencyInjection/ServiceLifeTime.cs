using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DependencyInjection
{
    public enum ServiceLifeTime
    {
        Singleton,
        Transient,
        Scoped
    }
}
