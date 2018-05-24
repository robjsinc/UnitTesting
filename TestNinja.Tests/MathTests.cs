using TestNinja.Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        Math _math = new Math();

        [Test]
        public void Max_WhenCalled_ReturnSumOfArguements()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArguement(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumnbersUptoLimit()
        {
            var result =  _math.GetOddNumbers(5);

            // Use this - most general
            Assert.That(result, Is.Not.Empty); 
            // Or this - more specific
            Assert.That(result.Count() == 3); 
            // Or this - most specific but not all three
            Assert.That(result, Does.Contain(1)); 
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));
            //which is the same as
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);           
        }
    }
}
