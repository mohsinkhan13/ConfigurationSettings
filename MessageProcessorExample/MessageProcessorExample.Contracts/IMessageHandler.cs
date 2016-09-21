using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.Contracts
{
    public interface IMessageHandler
    {
        void ProcessMessage(object message);
    }
}
