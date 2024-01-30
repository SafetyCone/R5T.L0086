using System;


namespace R5T.L0086.Construction
{
    class Program
    {
        static void Main()
        {
            var filePath = Instances.FilePaths.GitIgnoreTemplateFilePath;

            var fileExists = Instances.FileSystemOperator.Exists_File(filePath);

            Console.WriteLine($"{fileExists}: exists-file\n\t{filePath}");
        }
    }
}