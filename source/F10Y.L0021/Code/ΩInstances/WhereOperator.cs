using System;


namespace F10Y.L0021
{
    public class WhereOperator : IWhereOperator
    {
        #region Infrastructure

        public static IWhereOperator Instance { get; } = new WhereOperator();


        private WhereOperator()
        {
        }

        #endregion
    }
}
