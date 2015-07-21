using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Helper.Tests
{
    [TestFixture]
    public class PrefixHelperFactoryTest
    {
        [Test]
        public void IsInstanceOfIPrefixHelperFactory_GetsDefaultPrefixLength_ReturnsInstanceOfIPrefixHelperFactory()
        {
            Assert.IsInstanceOf(typeof(IPrefixHelper), PrefixHelperFactory.CreatePrefixHelper());
        }

        [Test]
        public void IsInstanceOfIPrefixHelperFactory_GetsPrefixLength_ReturnsInstanceOfIPrefixHelperFactory()
        {
            Assert.IsInstanceOf(typeof(IPrefixHelper), PrefixHelperFactory.CreatePrefixHelper(10));
        }
    }
}
