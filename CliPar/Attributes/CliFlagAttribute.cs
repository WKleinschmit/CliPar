using System;

namespace CliPar.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CliFlagAttribute : _NamedArgumentAttribute
    {
        public CliFlagAttribute(char shortName)
            : base(shortName)
        {
        }

        public CliFlagAttribute(char shortName, string longName)
            : base(shortName, longName)
        {
        }

        public CliFlagAttribute(string longName)
            : base(longName)
        {
        }

        public object SetValue { get; set; }
        public object UnsetValue { get; set; }
    }
}
