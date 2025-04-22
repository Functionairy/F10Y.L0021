using System;


namespace F10Y.L0021
{
    public static class IWhereCommandArgumentsBuilderExtensions
    {
        public static TWhereCommandArgumentsBuilder Set_Pattern<TWhereCommandArgumentsBuilder>(this TWhereCommandArgumentsBuilder builder,
            string pattern)
            where TWhereCommandArgumentsBuilder : IWhereCommandArgumentsBuilder
        {
            Instances.WhereCommandOperator.Set_Pattern(
                builder,
                pattern);

            return builder;
        }
    }
}
