using System;

namespace CliPar.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CliNamedArgumentAttribute : _NamedArgumentAttribute
    {
        public CliNamedArgumentAttribute(char shortName)
            :base(shortName)
        {
        }

        public CliNamedArgumentAttribute(char shortName, string longName)
            : base(shortName, longName)
        {
        }

        public CliNamedArgumentAttribute(string longName)
            : base(longName)
        {
        }
    }
}
