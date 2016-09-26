using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorXmplRevisited.Contracts
{
    public interface IMessageHandler<T> where T : BaseMessage
    {
        void Handle(T message);
    }
}
