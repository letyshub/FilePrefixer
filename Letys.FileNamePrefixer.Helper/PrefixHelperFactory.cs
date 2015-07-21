using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Helper
{
    public class PrefixHelperFactory
    {
        public static IPrefixHelper CreatePrefixHelper(int prefixLength)
        {
            return new RandomNumericPrefixHelper(prefixLength);
        }

        public static IPrefixHelper CreatePrefixHelper()
        {
            return new RandomNumericPrefixHelper(4);
        }
    }
}
