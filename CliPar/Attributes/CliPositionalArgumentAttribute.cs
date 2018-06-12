using System;

namespace CliPar.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CliPositionalArgumentAttribute : _ArgumentAttribute
    {
        public CliPositionalArgumentAttribute(int index)
        {
            Index = index;
        }

        public int Index { get; }
    }
}
