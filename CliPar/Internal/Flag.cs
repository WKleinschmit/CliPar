using System.Reflection;

namespace CliPar.Internal
{
    internal class Flag : _BaseArgument
    {
        internal Flag(PropertyInfo property)
        : base(property)
        {
        }
    }
}
