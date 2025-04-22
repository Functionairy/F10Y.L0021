using System;


namespace F10Y.L0021
{
    public static class Instances
    {
        public static IArgumentNames ArgumentNames => L0021.ArgumentNames.Instance;
        public static L0020.ICommandArgumentsBuilderOperator CommandArgumentsBuilderOperator => L0020.CommandArgumentsBuilderOperator.Instance;
        public static L0020.ICommandInvocationOperator CommandInvocationOperator => L0020.CommandInvocationOperator.Instance;
        public static L0020.ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static ICommandNames CommandNames => L0021.CommandNames.Instance;
        public static IWhereCommandOperator WhereCommandOperator => L0021.WhereCommandOperator.Instance;
        public static IWhereOperator WhereOperator => L0021.WhereOperator.Instance;
        public static IWherePatterns WherePatterns => L0021.WherePatterns.Instance;
    }
}