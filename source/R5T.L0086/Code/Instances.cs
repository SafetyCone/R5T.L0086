using System;


namespace R5T.L0086
{
    public static class Instances
    {
        public static L0071.IFilesDirectoryOperator FilesDirectoryOperator => L0071.FilesDirectoryOperator.Instance;
        public static IFileNames FileNames => L0086.FileNames.Instance;
        public static IProjectNames ProjectNames => L0086.ProjectNames.Instance;
    }
}