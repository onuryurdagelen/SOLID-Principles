using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    class ParaGonderici2
    {
        public void Gonder(IBanka banka,int tutar,string hesapNo)
        {
            banka.ParaTransferi(tutar, hesapNo);
        }
    }
    interface IBanka
    {
        bool ParaTransferi(int tutar, string hesapNo);
    }
    class Garanti : IBanka
    {
        public string HesapNo { get; set; }

        public void ParaGonder(int tutar)
        {
            //...
        }


        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                HesapNo = hesapNo;
                ParaGonder(tutar);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
    class Akbank : IBanka
    {
        private string _hesapNo;

        public void ParaGonder(int tutar)
        {
            //...
        }

        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                GonderilecekHesap(hesapNo);
                ParaGonder(tutar);
                return true;


            }
            catch (Exception)
            {

                throw;
            }
        }
        public void GonderilecekHesap(string hesapNo)
        {
            _hesapNo= hesapNo;
        }
    }
}
