using System.Reflection;

namespace CliPar.Internal
{
    internal class NamedArgument : _BaseArgument
    {
        internal NamedArgument(PropertyInfo property)
            : base(property)
        {
        }
    }
}
