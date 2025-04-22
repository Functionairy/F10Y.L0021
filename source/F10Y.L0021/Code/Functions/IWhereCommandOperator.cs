using System;

using F10Y.L0020;
using F10Y.T0002;


namespace F10Y.L0021
{
    [FunctionsMarker]
    public partial interface IWhereCommandOperator
    {
        public WhereCommandInvocationBuilder New()
            => new WhereCommandInvocationBuilder()
                .Set_Command(Instances.CommandNames.where);

        public void Set_Pattern(IWhereCommandArgumentsBuilder builder,
            string pattern)
            => Instances.CommandArgumentsBuilderOperator.Add_Argument(
                builder,
                Instances.ArgumentNames.Pattern,
                Instances.CommandInvocationOperator.Create_WordArgument(pattern));
    }
}
