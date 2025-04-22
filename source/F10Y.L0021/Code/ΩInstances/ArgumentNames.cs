using System;


namespace F10Y.L0021
{
    public class ArgumentNames : IArgumentNames
    {
        #region Infrastructure

        public static IArgumentNames Instance { get; } = new ArgumentNames();


        private ArgumentNames()
        {
        }

        #endregion
    }
}
