using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letys.FileNamePrefixer.File.Tests
{
    [TestFixture]
    public class FileControllerFactoryTest
    {
        [Test]
        public void IsInstanceOfIFileController_GetsDefaultPrefixLength_ReturnsInstanceOfIFileController()
        {
            IFileController fc = FileControllerFactory.CreateFileController(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.BaseDirectory);
            Assert.IsInstanceOf(typeof(IFileController), fc);
        }
    }
}
