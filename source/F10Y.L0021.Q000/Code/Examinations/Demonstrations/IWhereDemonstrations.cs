using System;
using System.Threading.Tasks;

using F10Y.L0020;
using F10Y.T0006;


namespace F10Y.L0021.Q000
{
    [DemonstrationsMarker]
    public partial interface IWhereDemonstrations
    {
        /// <summary>
        /// Write the where command help to a file.
        /// </summary>
        public async Task Where_Help()
        {
            /// Inputs.
            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var results = Instances.WhereOperator.Where_Help();

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                results);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }

        /// <summary>
        /// Use the <see cref="IWhereOperator"/>.
        /// </summary>
        public async Task Where_IsWhere_WhereOperator()
        {
            /// Inputs.
            var pattern =
                Instances.WherePatterns.NON_EXISTENT
                ;

            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var results = Instances.WhereOperator.Where(
                pattern
                );

            await Instances.FileOperator.Write_Lines(
                output_TextFilePath,
                results);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }

        /// <summary>
        /// Use the <see cref="IWhereCommandInvocationBuilder"/> syntax.
        /// </summary>
        public async Task Where_IsWhere_CommandSyntax()
        {
            /// Inputs.
            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var commandInvocation = Instances.WhereCommandOperator.New()
                .Set_Pattern("where")
                .Build()
                ;

            var commandResult = Instances.CommandLineOperator.Run_Synchronous(commandInvocation);

            await Instances.CommandResultOperator.Describe_ToFile(
                commandResult,
                output_TextFilePath);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }

        /// <summary>
        /// Run the where command on itself.
        /// </summary>
        public async Task Where_IsWhere_SimpleSyntax()
        {
            /// Inputs.
            var output_TextFilePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            var commandInvocation = Instances.CommandInvocationOperator.New()
                .Set_Command("where")
                .Add_Argument(
                    "pattern",
                    new WordArgument("where"))
                .Build()
                ;

            //using var writer = Instances.FileOperator.Open_ForWrite(output_TextFilePath);

            //var commandResult = Instances.CommandLineOperator.Run_Synchronous(
            //    commandInvocation,
            //    Instances.ProcessOperator.Get_DataReceivedEventHandler_Synchronous(writer));

            var commandResult = Instances.CommandLineOperator.Run_Synchronous(commandInvocation);

            await Instances.CommandResultOperator.Describe_ToFile(
                commandResult,
                output_TextFilePath);

            Instances.NotepadPlusPlusOperator.Open(output_TextFilePath);
        }
    }
}
