using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true});

            //Assert
            Assert.IsTrue(result); // three idential assertions - 1
            Assert.That(result == true); // 2
            Assert.That(result, Is.True); // 3
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelledReservation_ReturnTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
