using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    class ParaGonderici
    {

        public void Gonder(int tutar)
        {
            Garanti2 garanti = new();
            garanti.HesapNo = "...";
            garanti.ParaGonder(tutar);
        }
        
    }
    class Garanti2
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            //...
        }
    }
    class Halkbank2
    {
        string _hesapNo;

        public void GonderilecekHesap(string hesapNo)
        {
            //...
        }
        public void ParaGonder(int tutar)
        {
            //...
        }
    }
    class Akbank2
    {
        //...
    }
}
