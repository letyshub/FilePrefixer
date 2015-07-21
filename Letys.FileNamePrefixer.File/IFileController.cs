using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.File
{
    public interface IFileController
    {
        IList<ConvertedFile> ConvertedFiles { get; }
        void ConvertFiles();
    }
}
