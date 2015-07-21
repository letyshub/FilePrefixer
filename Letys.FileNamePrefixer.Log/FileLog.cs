using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Log
{
    public class FileLog : ILog
    {
        private Logger logger;

        public FileLog()
        {
            this.logger = LogManager.GetLogger("Example");
        }

        public void Error(Exception ex)
        {
            this.logger.Error(ex);
        }

        public void Info(string message)
        {
            this.logger.Info(message);
        }
    }
}
