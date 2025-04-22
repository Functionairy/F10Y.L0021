using System;

using F10Y.T0003;


namespace F10Y.L0021
{
    [ValuesMarker]
    public partial interface IWherePatterns
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>NON_EXISTENT</value></para>
        /// </summary>
        public string NON_EXISTENT => "NON_EXISTENT";

        /// <summary>
        /// <para><value>help</value></para>
        /// </summary>
        public string help => "/?";

        /// <summary>
        /// <para><value>where</value></para>
        /// </summary>
        public string where => "where";

#pragma warning restore IDE1006 // Naming Styles
    }
}
