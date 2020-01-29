using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = new MessageHandler();
            Message message = new Message("a", "b", "hi", "you", "hi again");

            string[] to =
            {
                "Jon",
                "Steve"
            };

            handler.HandleMassage(to, message, true, MessageCarrier.Smtp);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
