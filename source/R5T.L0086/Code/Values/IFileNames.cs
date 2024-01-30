using System;

using R5T.T0131;


namespace R5T.L0086
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>gitignore-template.txt</value></para>
        /// </summary>
        public string GitIgnoreTemplate => "gitignore-template.txt";
    }
}
