using System;

namespace CliPar
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CliCommandAttribute : Attribute
    {
        public CliCommandAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
