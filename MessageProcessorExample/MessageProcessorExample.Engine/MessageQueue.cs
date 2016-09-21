using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.Engine
{
    public class MessageQueue
    {

        private Queue<object> _messages = new Queue<object>();

        public void SendMessage(object message)
        {
            _messages.Enqueue(message);
        }

        public object GetNextMessage()
        {
            return _messages.Dequeue();
        }

    }
}
