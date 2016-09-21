using MessageProcessorExample.Contracts;
using MessageProcessorExample.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.MessageHandlers
{
    public class SendEmailMessageHandler : MessageHandler<SendEmailMessage>
    {
        public override void ProcessMessage(SendEmailMessage message)
        {
            // handle logic
        }

    }

}
