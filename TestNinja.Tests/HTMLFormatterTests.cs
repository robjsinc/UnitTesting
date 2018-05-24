using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncolseStringWithStrongElement()
        {
            //Arrange
            var formatter = new HtmlFormatter();
            var str = "string";
            //Act
            var result = formatter.FormatAsBold(str);

            //Assertions - three types

            //Specific
            Assert.That(result, Is.EqualTo("<strong>string</strong>"));

            //More General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("string").IgnoreCase);
        }

    }
}
