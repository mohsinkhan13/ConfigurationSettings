using MessageProcessorExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageProcessorExample.Messages
{
    public class SendEmailMessage : MessageBase
    {
        public string EmailAddress { get; set; }
    }
}
