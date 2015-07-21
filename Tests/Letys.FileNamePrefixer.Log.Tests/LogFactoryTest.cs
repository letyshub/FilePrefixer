using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.Log.Tests
{
    [TestFixture]
    public class LogFactoryTest
    {
        [Test]
        public void IsInstanceOfILog_GetsRequestOfLogger_ReturnsInstanceOfILog()
        {
            Assert.IsInstanceOf(typeof(ILog), LogFactory.GetFileLogger());
        }
    }
}
