using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{

    //Type - 1 with using Interface

    class MailSender
    {
        public void Send(IMailServer mailServer)
        {
            mailServer.Send("blabla@gmail.com", "Heyy!!");
        }
        public void Send2(MailServerBase mailServerBase)
        {
            mailServerBase.SendBase("blabla@gmail.com", "Heyy!!");
        }
    }
    interface IMailServer
    {
        void Send(string to, string body);
    }
    class Gmail : MailServerBase,IMailServer
    {
        public void Send(string to, string body)
        {
            //...
        }
        public override void SendBase(string to, string body)
        {
            Console.WriteLine($"Sent to Gmail to {to} with {body}");
        }
    }
    class Hotmail : MailServerBase,IMailServer
    {
        public void Send(string to, string body)
        {
            //...
        }
        public override void SendBase(string to, string body)
        {
            Console.WriteLine($"Sent to Hotmail to {to} with {body}");
        }
    }
    class Yandex : MailServerBase,IMailServer
    {
        public void Send(string to, string body)
        {
            //...
        }
        public override void SendBase(string to, string body)
        {
            Console.WriteLine($"Sent to Yandex to {to} with {body}");
        }
    }

    //Type - 2 with using abstract class

    abstract class MailServerBase
    {
        public virtual void SendBase(string to, string body)
        {

        }
    }

}
