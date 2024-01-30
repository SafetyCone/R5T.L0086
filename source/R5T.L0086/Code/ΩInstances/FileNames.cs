using System;


namespace R5T.L0086
{
    public class FileNames : IFileNames
    {
        #region Infrastructure

        public static IFileNames Instance { get; } = new FileNames();


        private FileNames()
        {
        }

        #endregion
    }
}
