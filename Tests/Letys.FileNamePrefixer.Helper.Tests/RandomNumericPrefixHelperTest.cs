using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Helper.Tests
{
    [TestFixture]
    public class RandomNumericPrefixHelperTest
    {
        [Test]
        public void IsInstanceOfIPrefixHelperFactory_GetsPrefixLength_ReturnsInstanceOfIPrefixHelperFactory()
        {
            RandomNumericPrefixHelper rnph = new RandomNumericPrefixHelper(10);
            Assert.IsInstanceOf(typeof(IPrefixHelper), rnph);
        }

        [Test]
        public void GetPrefix_GetCorrectParameters_ReturnCorrectPrefix()
        {
            RandomNumericPrefixHelper rnph = new RandomNumericPrefixHelper(5);
            Assert.AreEqual(5, rnph.GetPrefix().Length);
        }

        [Test]
        public void GetPrefix_GetCorrectParameters_ReturnNumericPrefix()
        {
            int result;
            RandomNumericPrefixHelper rnph = new RandomNumericPrefixHelper(5);

            Assert.True(Int32.TryParse(rnph.GetPrefix(), out result));
        }

        [Test]
        public void GetPrefix_GetCorrectParameters_ReturnNumericPrefixInCorrectRange()
        {
            RandomNumericPrefixHelper rnph = new RandomNumericPrefixHelper(4);
            int prefix = Convert.ToInt32(rnph.GetPrefix());

            Assert.True(prefix > 0);
            Assert.Less(prefix, 10000);
        }
    }
}
