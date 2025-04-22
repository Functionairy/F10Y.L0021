using System;


namespace F10Y.L0021.Q000
{
    public class WhereDemonstrations : IWhereDemonstrations
    {
        #region Infrastructure

        public static IWhereDemonstrations Instance { get; } = new WhereDemonstrations();


        private WhereDemonstrations()
        {
        }

        #endregion
    }
}
