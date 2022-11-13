using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DependencyInjection
{
    public class SomeServiceOne : ISomeService
    {
        private readonly IRandomGuidProvider _randomGuidProvider;

        public SomeServiceOne(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }

        //private readonly Guid RandomGuid = Guid.NewGuid();

        public void PrintSomething()
        {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}
