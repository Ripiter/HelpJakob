using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class SmtpSender : MessageSender
    {
        public override void SendMessage(Message m)
        {
            Console.WriteLine("Message send from Smtp Class");
        }
        
    }
}
