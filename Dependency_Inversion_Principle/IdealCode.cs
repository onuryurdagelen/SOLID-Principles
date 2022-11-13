using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal class IdealCode
    {
    }
    class MailService
    {
        public void SendMail(IMailService mailService, string to, string body)
        {
            mailService.Send(to, body);
        }
        
    }
    interface IMailService
    {
        void Send(string to, string body);
    }
    class Gmail : IMailService
    {
        public void Send(string to, string body)
        {
            //...Send Mail...
        }
    }
    class Yandex : IMailService
    {
        public void Send(string to, string body)
        {
            //...Send Mail...
        }
    }
    class Hotmail : IMailService
    {
        public void Send(string to, string body)
        {
            //...Send Mail...
        }
    }
}
