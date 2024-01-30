using System;


namespace R5T.L0086.Construction
{
    public static class Instances
    {
        public static IFilePaths FilePaths => L0086.FilePaths.Instance;
        public static L0066.IFileSystemOperator FileSystemOperator => L0066.FileSystemOperator.Instance;
    }
}