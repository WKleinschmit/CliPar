namespace CliPar.Attributes
{
    public abstract class _NamedArgumentAttribute : _ArgumentAttribute
    {
        protected _NamedArgumentAttribute(char shortName)
        {
            ShortName = shortName;
        }

        protected _NamedArgumentAttribute(char shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;
        }

        protected _NamedArgumentAttribute(string longName)
        {
            LongName = longName;
        }

        public char? ShortName { get; }
        public string LongName { get; }
    }
}
