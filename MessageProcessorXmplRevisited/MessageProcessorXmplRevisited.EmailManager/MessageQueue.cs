using MessageProcessorXmplRevisited.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorXmplRevisited.EmailManager
{
    public class MessageQueue
    {
        private readonly Queue<EmailMessage> _message = new Queue<EmailMessage>();

        public void SendMessage(EmailMessage message)
        {
            _message.Enqueue(message);
        }
    }
}
