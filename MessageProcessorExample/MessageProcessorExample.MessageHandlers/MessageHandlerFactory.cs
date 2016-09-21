using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageProcessorExample.Messages;
using MessageProcessorExample.Contracts;

namespace MessageProcessorExample.MessageHandlers
{
    public class MessageHandlerFactory
    {
        public IMessageHandler Create(MessageBase msg)
        {

            // would use MEF - plugin discovery
            var handlers = this.GetType().Assembly.GetTypes().Where(t =>
                t.BaseType != null &&
                t.BaseType.GetInterfaces().Any(i => i == typeof(IMessageHandler))
            );

            var handler = handlers.FirstOrDefault(h => h.BaseType.GenericTypeArguments.Any(a => a == msg.GetType()));

            var instance = Activator.CreateInstance(handler) as IMessageHandler;

            return instance;

        }

    }

}
