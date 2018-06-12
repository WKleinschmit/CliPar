using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using CliPar.Attributes;
using CliPar.Internal;

namespace CliPar
{
    public class CliParser
    {
        List<PositionalArgument> PositionalArguments = new List<PositionalArgument>();
        Dictionary<string, NamedArgument> NamedArguments = new Dictionary<string, NamedArgument>();
        Dictionary<string, Flag> Flags = new Dictionary<string, Flag>();
        private static ResourceManager _resources;

        public static ResourceManager Resources
        {
            get => _resources ?? Properties.Resources.ResourceManager;
            set => _resources = value;
        }

        private static string ResourceString(string key)
        {
            return Resources.GetString(key);
        }

        public void Parse<T>(string[] args)
        {
            Init(typeof(T));


        }

        private void Init(Type type)
        {
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.GetCustomAttribute<CliPositionalArgumentAttribute>() is CliPositionalArgumentAttribute pa)
                    PositionalArguments.Add(new PositionalArgument(pa.Index, property));

                if (property.GetCustomAttribute<CliNamedArgumentAttribute>() is CliNamedArgumentAttribute na)
                {
                    NamedArgument namedArgument = new NamedArgument(property);
                    if (na.ShortName.HasValue)
                        NamedArguments[na.ShortName.ToString()] = namedArgument;
                    if (na.LongName != null)
                        NamedArguments[na.LongName] = namedArgument;
                }

                if (property.GetCustomAttribute<CliFlagAttribute>() is CliFlagAttribute f)
                {
                    Flag flag = new Flag(property);
                    if (f.ShortName.HasValue)
                        Flags[f.ShortName.ToString()] = flag;
                    if (f.LongName != null)
                        Flags[f.LongName] = flag;
                }
            }

            PositionalArguments = new List<PositionalArgument>(PositionalArguments.OrderBy(pa => pa.Index));
            if (PositionalArguments.Count > 2)
                foreach (PositionalArgument pa in PositionalArguments.Take(PositionalArguments.Count - 1))
                {
                    if (pa.IsList)
                        throw new CliException(ResourceString("EX_MultiPosArgument"));
                }
        }
    }
}
