using MessageProcessorXmplRevisited.Handlers;
using MessageProcessorXmplRevisited.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorXmplRevisited.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new EmailMessage
            {
                To = "To",
                From = "From"
            };

            //var handler = new Handlers.EmailMessageHandler();
            var handler = new HandlerFactory().Create<EmailMessage>();

            handler.Handle(message);
            Console.WriteLine("Message sent !");
            Console.Read();
        }
    }
}
