using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArguementNullException(string error)
        {
            var logger = new ErrorLogger();

            // logger.Log(error); // cant add a returned exception to an object so wont work
            //we need to throw the exeption in the Assert.That below

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
            //same as above - might need to use one or other in different circumstances
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

    }
}
