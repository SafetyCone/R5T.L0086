using System;

using R5T.T0131;


namespace R5T.L0086
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        private static readonly Lazy<string> zGitIgnoreTemplateFilePath = new Lazy<string>(
            () => Instances.FilesDirectoryOperator.Get_FilesDirectory_FilePath(
                Instances.ProjectNames.R5T_L0086_Z000,
                Instances.FileNames.GitIgnoreTemplate
            )
        );

        public string GitIgnoreTemplateFilePath => IFilePaths.zGitIgnoreTemplateFilePath.Value;
    }
}
