using System;


namespace F10Y.L0021.Q000
{
    public static class Instances
    {
        public static L0020.ICommandInvocationOperator CommandInvocationOperator => L0020.CommandInvocationOperator.Instance;
        public static L0020.ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static L0020.ICommandResultOperator CommandResultOperator => L0020.CommandResultOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static L0004.IFilePaths FilePaths => L0004.FilePaths.Instance;
        public static L0019.INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
        public static IWhereCommandOperator WhereCommandOperator => L0021.WhereCommandOperator.Instance;
        public static IWhereOperator WhereOperator => L0021.WhereOperator.Instance;
        public static IWherePatterns WherePatterns => L0021.WherePatterns.Instance;
    }
}