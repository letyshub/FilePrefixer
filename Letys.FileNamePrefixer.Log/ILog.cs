﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Log
{
    public interface ILog
    {
        void Error(Exception ex);
        void Info(string message);
    }
}
