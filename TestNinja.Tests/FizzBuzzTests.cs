using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutPut_DividesBy3And5_ReturnFizzBuzz()
        {
            //Act
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutPut_DividesBy3Not5_ReturnFizz()
        {
            //Act
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutPut_DividesBy5Not3_ReturnBuzz()
        {
            //Act
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        public void GetOutPut_DoesntDivideBy3Or5_ReturnSameNumber()
        {
            //Act
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
