using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        CustomerController _controller = new CustomerController();

        [Test]
        public void GetCustomer_WhenIdEqualsZero_ReturnsNotFoundObject()
        {
            var result = _controller.GetCustomer(0);

            Assert.That(result, Is.InstanceOf<NotFound>()); // Notfound object or a derivative
            Assert.That(result, Is.TypeOf<NotFound>()); // Notfound object only

        }

        [Test]
        public void GetCustomer_WhenIdNotZero_ReturnsOkObject()
        {
            var result = _controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
            Assert.That(result, Is.InstanceOf<Ok>());

        }
    }
}
