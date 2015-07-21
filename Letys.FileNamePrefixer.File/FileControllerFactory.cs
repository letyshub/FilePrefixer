using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.File
{
    public static class FileControllerFactory
    {
        public static IFileController CreateFileController(string sourceFolder, string targetFolder)
        {
            return new FileController(sourceFolder, targetFolder);
        }
    }
}
