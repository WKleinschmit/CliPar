using System.Reflection;

namespace CliPar.Internal
{
    internal class PositionalArgument : _BaseArgument
    {
        internal PositionalArgument(int index, PropertyInfo property)
            : base(property)
        {
            Index = index;
        }

        public int Index { get; }
    }
}
