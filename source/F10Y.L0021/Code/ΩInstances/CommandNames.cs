using System;


namespace F10Y.L0021
{
    public class CommandNames : ICommandNames
    {
        #region Infrastructure

        public static ICommandNames Instance { get; } = new CommandNames();


        private CommandNames()
        {
        }

        #endregion
    }
}
