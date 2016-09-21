using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.Contracts
{
    public abstract class MessageHandler<T> : IMessageHandler
    {

        public void ProcessMessage(object message)
        {
            ProcessMessage((T)message);
        }

        public abstract void ProcessMessage(T message);

    }

}
