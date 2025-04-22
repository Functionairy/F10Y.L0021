using System;
using System.Collections.Generic;

using F10Y.L0020;
using F10Y.T0004;


namespace F10Y.L0021
{
    [UtilityTypeMarker]
    public class WhereCommandArgumentsBuilder : CommandArgumentsBuilder, IWhereCommandArgumentsBuilder
    {
        public WhereCommandArgumentsBuilder()
            : base()
        {
        }

        public WhereCommandArgumentsBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            : base(arguments_ByArgumentName)
        {
        }
    }
}
