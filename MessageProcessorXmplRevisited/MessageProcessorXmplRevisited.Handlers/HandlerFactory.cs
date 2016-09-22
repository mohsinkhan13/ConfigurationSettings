using MessageProcessorXmplRevisited.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageProcessorXmplRevisited.Handlers
{
    public class HandlerFactory
    {
        public IMessageHandler<T> Create<T>() where T : BaseMessage
        {
            var handlers = GetHandlerTypes<T>().ToList();

            var cmdHandler = handlers.Select(handler =>
                (IMessageHandler<T>)Activator.CreateInstance(handler)).FirstOrDefault();

            return cmdHandler;
        }

        private IEnumerable<Type> GetHandlerTypes<T>() where T : BaseMessage
        {
            var handlers = this.GetType().Assembly.GetExportedTypes()
                .Where(x => x.GetInterfaces()
                    .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(IMessageHandler<>)))
                    .Where(h => h.GetInterfaces()
                        .Any(ii => ii.GetGenericArguments()
                            .Any(aa => aa == typeof(T)))).ToList();

            return handlers;
        }
    }
}
