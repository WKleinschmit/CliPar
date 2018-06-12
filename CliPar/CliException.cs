using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CliPar
{
    public class CliException : ApplicationException
    {
        public CliException()
        {
        }

        public CliException(string message)
            : base(message)
        {
        }

        protected CliException(SerializationInfo info, StreamingContext context)
        :base(info, context)
        {
        }

    }
}
