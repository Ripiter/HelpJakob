using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class MessageHandler
    {
        MessageSender sender;

        public void HandleMassage(Message message, bool isHtml, MessageCarrier carrier)
        {
            SetSender(carrier);

            if (isHtml)
                message.Body = Converter.ConvertBodyToHTML(message.Body);

            sender.SendMessage(message);
        }

        public void HandleMassage(string[] to, Message message, bool isHtml, MessageCarrier carrier)
        {
            SetSender(carrier);

            if (isHtml)
                message.Body = Converter.ConvertBodyToHTML(message.Body);

            foreach (string m in to)
            {
                message.To = m;
                sender.SendMessage(message);
            }
        }


        void SetSender(MessageCarrier carrier)
        {
            switch (carrier)
            {
                case MessageCarrier.Smtp:
                    sender = new SmtpSender();
                    break;
                case MessageCarrier.VMessage:
                    sender = new VMessageSender();
                    break;
                default:
                    break;
            }
        }
    }
}
