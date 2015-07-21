using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letys.FileNamePrefixer.File;

namespace Letys.FileNamePrefixer.File.Tests
{
    [TestFixture]
    public class FileControllerTest
    {
        [Test]
        public void IsInstanceOfIFileController_GetsCorrectConstructorParams_ReturnsInstanceOfIFileController()
        {
            FileController fc = new FileController(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.BaseDirectory);
            Assert.IsInstanceOf(typeof(IFileController), fc);
        }

        [Test]
        public void IsInstanceOfIFileController_GetsIncorrectConstructorParams_ThrowsArgumentException()
        {            
            FileController fc = null;
            Assert.Throws<ArgumentException>(() => fc = new FileController("test incorrect path", AppDomain.CurrentDomain.BaseDirectory));
        }
    }
}
