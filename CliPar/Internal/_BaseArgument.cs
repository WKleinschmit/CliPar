using System.Collections;
using System.Reflection;

namespace CliPar.Internal
{
    internal abstract class _BaseArgument
    {
        protected internal _BaseArgument(PropertyInfo property)
        {
            Property = property;
            IsList = typeof(IList).IsAssignableFrom(property.PropertyType);
        }

        internal PropertyInfo Property { get; }
        internal bool IsList { get; }
    }
}
