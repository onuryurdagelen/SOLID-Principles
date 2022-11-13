using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{

    //Mail göndermek için Gmail sınıfına bağımlı oluruz.MailSender Gmail sınıfına bağımlıdır.
    class MailSenderx
    {
        public void Send()
        {
            //Gmail gmail = new(); //constructor değişikli oldu.
            //gmail.Send("onuryurdagelen@gmail.com","asdasd"); //Send() metoduna parametre eklendi.
        }
    }

    //Gmail sınıfında Send() sınıfında değişiklik yaptığımızda MailSender yapısı değişir
    //class Gmailx
    //{

    //    public Gmail()
    //    {

    //    }

    //    public void Send(string to)
    //    {
    //        //...
    //    }
    //}
    //class Hotmailx
    //{
    //    public Hotmail()
    //    {

    //    }

    //    public void Send(string to)
    //    {
    //        //...
    //    }
    //}
}
