using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Princibple
{
     class Database2
    {
    
    public void Connect() {

            Console.WriteLine("Veritabanı bağlantı sağlandı...");
        }
        public void Disconnect() {
            Console.WriteLine("Veritabanı bağlantısı kesildi..");
        }    
    }

    class PersonService
    {

        public List<Person> GetPeople()
        {
            return new()
            {
                new() {Name ="Onur",Surname="Yurdagelen"},
                new() {Name ="Kaan",Surname="Yurdagelen"},
                new() {Name ="Bekir",Surname="Yurdagelen"},
            };
        }
    }
}
