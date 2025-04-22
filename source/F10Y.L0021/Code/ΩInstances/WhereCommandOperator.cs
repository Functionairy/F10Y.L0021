using System;


namespace F10Y.L0021
{
    public class WhereCommandOperator : IWhereCommandOperator
    {
        #region Infrastructure

        public static IWhereCommandOperator Instance { get; } = new WhereCommandOperator();


        private WhereCommandOperator()
        {
        }

        #endregion
    }
}
