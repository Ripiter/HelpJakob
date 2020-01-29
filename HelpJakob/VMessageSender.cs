using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class VMessageSender : MessageSender
    {
        public override void SendMessage(Message m)
        {
            Console.WriteLine("Message send from Vmessage Class");
        }
    }
}
