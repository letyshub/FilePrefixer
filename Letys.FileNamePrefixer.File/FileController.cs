using Letys.FileNamePrefixer.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.File
{
    public class FileController : IFileController
    {
        private IList<FileInfo> files;
        private string targetFolder;
        private string sourceFolder;
        private IPrefixHelper prefixHelper;
        private IList<ConvertedFile> convertedFiles;

        public FileController(string sourceFolder, string targetFolder) : this(sourceFolder, targetFolder, 5)
        {            
        }

        public FileController(string sourceFolder, string targetFolder, int prefixLength)
        {
            this.ChecksParams(sourceFolder, targetFolder);

            this.sourceFolder = sourceFolder;
            this.targetFolder = targetFolder;
            this.prefixHelper = PrefixHelperFactory.CreatePrefixHelper();
            this.convertedFiles = new List<ConvertedFile>();

            this.LoadFiles();
        }

        public void ConvertFiles()
        {
            this.convertedFiles.Clear();

            Parallel.ForEach(this.files.OrderBy(x => x.Name),
                (x) =>
                {
                    string prefix = this.prefixHelper.GetPrefix();
                    string newName = string.Format("{0} - {1}", prefix, x.Name);
                    this.CopyFile(x.Name, newName);
                    this.convertedFiles.Add(new ConvertedFile { OldName = x.Name, NewName = newName });
                });
        }

        private void LoadFiles()
        {
            DirectoryInfo di = new DirectoryInfo(this.sourceFolder);
            this.files = di.GetFiles();
        }

        private void ChecksParams(string sourceFolder, string targetFolder)
        {
            if (!System.IO.Directory.Exists(sourceFolder))
            {
                throw new ArgumentException(@"Source folder doesn't exist.", "sourceFolder");
            }

            if (!System.IO.Directory.Exists(targetFolder))
            {
                throw new ArgumentException(@"Target folder doesn't exist.", "targetFolder");
            }
        }

        private void CopyFile(string oldName, string newName)
        {
            FileInfo fi = this.files.FirstOrDefault(x => x.Name == oldName);
            fi.CopyTo(string.Format(@"{0}\{1}", this.targetFolder, newName));            
        }

        public IList<ConvertedFile> ConvertedFiles
        {
            get { return this.convertedFiles; }
        }
    }
}
