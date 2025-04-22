using System;

using F10Y.L0020;
using F10Y.T0002;


namespace F10Y.L0021
{
    [FunctionsMarker]
    public partial interface IWhereOperator
    {
        public string[] Where_Help()
            => this.Where(Instances.WherePatterns.help);

        public string[] Where(string pattern)
        {
            var commandInvocation = Instances.WhereCommandOperator.New()
                .Set_Pattern(pattern)
                .Build()
                ;

            var commandResult = Instances.CommandLineOperator.Run_Synchronous(commandInvocation);

            var is_Success = commandResult.Is_Success();

            var output = is_Success
                ? commandResult.OutputLines
                : commandResult.ErrorLines
                ;

            return output;
        }
    }
}
