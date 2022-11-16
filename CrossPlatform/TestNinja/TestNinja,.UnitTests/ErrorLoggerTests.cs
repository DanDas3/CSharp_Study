using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja_.UnitTests
{
    [TestFixture]
    internal class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("aa");

            Assert.That(logger.LastError,Is.EqualTo("aa"));
        }
        
        [Test]
        [TestCase(null)]
        //[ExpectedException(typeof(ArgumentNullException))]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var errorLogger = new ErrorLogger();

            Assert.That(() => errorLogger.Log(error), Throws.ArgumentNullException);
        }
    }
}
