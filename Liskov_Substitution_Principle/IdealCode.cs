using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    abstract class Cloud2
    {
        public abstract void MachineLearning();
    }
    interface ITranslatable
    {
        void Translate();
    }
    class AWS2 : Cloud2, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("AWS Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("AWS Translate");
        }
    }
    class Azure2 : Cloud2
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");
        }
    }
    class Google2 : Cloud2, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Google Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("Google Translate");
        }
    }
}
