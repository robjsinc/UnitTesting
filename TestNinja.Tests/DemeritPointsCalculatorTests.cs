using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _dpc = new DemeritPointsCalculator();

        [Test]
        [TestCase(-1)]
        [TestCase(301)] 
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsException(int speed)
        {
            Assert.That(() => _dpc.CalculateDemeritPoints(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        public void CalculateDemeritPoints_SpeedIsAboveMaxSpeed_ThrowsException(int speed)
        {
            Assert.That(() => _dpc.CalculateDemeritPoints(301), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)] //speed zero returns 0 points
        [TestCase(64,0)] // speed within speed limit return 0 points
        [TestCase(65,0)] // speed on speed limit return 0 points
        [TestCase(66,0)] // 66kmp returns 0 point 
        [TestCase(70, 1)] // 70kmh returns 1 point 
        [TestCase(75, 2)] // 75kmh returns 2 point 
        public void CalculateDemeritPoints_WhenCalledReturnsDemeritPoints_ReturnsZero(int speed, int result)
        {
            var points = _dpc.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(result));

        }

    }
}
