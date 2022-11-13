using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{

    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }
    interface IPrintDublex
    {
        void PrintDublex();
    }

    class HPPrinter : IPrint, IScan
    {
        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
