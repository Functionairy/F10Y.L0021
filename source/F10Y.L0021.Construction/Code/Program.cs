using System;
using System.Threading.Tasks;


namespace F10Y.L0021.Construction
{
    class Program
    {
        static async Task Main()
        {
            //await Program.Scripts_();

            //await Program.Demonstrations_();
            await Program.Demonstrations_Where();
        }

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

        #region Demonstrations

        static Task Demonstrations_()
        {
            throw new NotImplementedException();
        }

        static async Task Demonstrations_Where()
        {
            await Instances.WhereDemonstrations.Where_Help();
            //await Instances.WhereDemonstrations.Where_IsWhere_WhereOperator();
            //await Instances.WhereDemonstrations.Where_IsWhere_CommandSyntax();
            //await Instances.WhereDemonstrations.Where_IsWhere_SimpleSyntax();
        }

        #endregion

        #region Scripts

        static Task Scripts_()
        {
            throw new NotImplementedException();
        }

        #endregion

#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0079 // Remove unnecessary suppression
    }
}