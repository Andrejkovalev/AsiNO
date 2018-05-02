using System;
using System.Collections.Generic;
using System.Text;

namespace AsiNO_BLL.Infrastructure
{
    public class OperationDetails
    {
        public bool Succedeed { get; private set; }
        public string Message { get; private set; }
        public string Prop { get; private set; }

        public OperationDetails(bool succedeed, string message, string prop)
        {
            Succedeed = succedeed;
            Message = message;
            Prop = prop;
        }
    }
}
