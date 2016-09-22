using System;
using MessageProcessorXmplRevisited.Contracts;
using MessageProcessorXmplRevisited.EmailManager;
using MessageProcessorXmplRevisited.Model;

namespace MessageProcessorXmplRevisited.Handlers
{
    public class EmailMessageHandler : IMessageHandler<EmailMessage>
    {
        public void Handle(EmailMessage message)
        {
            var queueManager = new MessageQueue();
            queueManager.SendMessage(message as EmailMessage);
        }
    }
}
