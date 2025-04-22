using System;


namespace F10Y.L0021
{
    public class WherePatterns : IWherePatterns
    {
        #region Infrastructure

        public static IWherePatterns Instance { get; } = new WherePatterns();


        private WherePatterns()
        {
        }

        #endregion
    }
}
