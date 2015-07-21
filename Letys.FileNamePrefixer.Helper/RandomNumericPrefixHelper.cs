using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Helper
{
    public class RandomNumericPrefixHelper : IPrefixHelper
    {
        private int prefixLength;
        private static readonly ThreadLocal<Random> randGenerator = new ThreadLocal<Random>(() => new Random());

        public RandomNumericPrefixHelper(int prefixLength)
        {
            this.prefixLength = prefixLength;
        }

        public string GetPrefix()
        {
            int prefix = randGenerator.Value.Next(1, (int)Math.Pow(10, this.prefixLength));

            return prefix.ToString().PadLeft(this.prefixLength, '0');
        }
    }
}
