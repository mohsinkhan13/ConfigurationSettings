using MessageProcessorXmplRevisited.Contracts;

namespace MessageProcessorXmplRevisited.Model
{
    public class EmailMessage : BaseMessage
    {
        public string To { get; set; }
        public string From { get; set; }
    }
}
