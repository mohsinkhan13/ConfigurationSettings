using MessageProcessorExample.Engine;
using MessageProcessorExample.MessageHandlers;
using MessageProcessorExample.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.client
{
    class Program
    {
        static void Main(string[] args)
        {

            var q = new MessageQueue();

            #region in another process
            var msg = new SendEmailMessage()
            {
                EmailAddress = "bob@mail.com"
            };
            
            q.SendMessage(msg);

            #endregion

            var outMsg = q.GetNextMessage();

            var handlerFactory = new MessageHandlerFactory();

            var handler = handlerFactory.Create(msg);

            handler.ProcessMessage(msg);

        }
    }
}
