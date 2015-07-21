using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Log
{
    public class LogFactory
    {
        public static ILog GetFileLogger()
        {
            return new FileLog();
        }
    }
}
