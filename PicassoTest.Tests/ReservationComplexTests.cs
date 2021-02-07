using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class ReservationComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledByAdminReturnsTrue()
        {
            //Arrange
            var user = new User();
            user.IsAdmin = true;

            var user2 = new User();
            user2.IsAdmin = false;

            var reservationComplex = new ReservationComplex();
            reservationComplex.MadeBy = user2;

            //Act
            var result = reservationComplex.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledByMadeByReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservationComplex = new ReservationComplex();
            reservationComplex.MadeBy = user;

            //Act
            var result = reservationComplex.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledByNotAdminNotMadeByReturnsFalse()
        {
            //Arrange
            var user = new User();
            user.IsAdmin = false;
            var user2 = new User();
            var reservationComplex = new ReservationComplex();
            reservationComplex.MadeBy = user2;

            //Act
            var result = reservationComplex.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledByNullUserReturnThrowsException()
        {
            //Arrange
            var reservation = new ReservationComplex();

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => reservation.CanBeCancelledBy(null));
        }


        [Test]
        public void ReservationIsPaidReturns0()
        {
            //Arrange
            var userComplex = new UserComplex();
            userComplex.Money = 400;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 150;

            //Act
            var result = reservationComplex.PayReservation(userComplex);

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }

        [Test]
        public void ReservationIsNotPaidReturnsDifference()
        {
            //Arrange
            var userComplex = new UserComplex();
            userComplex.Money = 150;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 200;

            //Act
            var result = reservationComplex.PayReservation(userComplex);
            var total = reservationComplex.Price - userComplex.Money;

            //Assert
            Assert.That(result, Is.EqualTo(total));

        }

        [Test]
        public void ReservationIsPaidMoneyEqualsPriceReturns0()
        {
            //Arrange
            var userComplex = new UserComplex();
            userComplex.Money = 100;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 100;

            //Act
            var result = reservationComplex.PayReservation(userComplex);

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }

        [Test]
        public void UserMoneyIsReduced()
        {
            //Arrange
            var userComplex = new UserComplex();
            userComplex.Money = 200;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 100;

            //Act
            var result = userComplex.Money - reservationComplex.Price;
            reservationComplex.PayReservation(userComplex);

            //Assert
            Assert.That(userComplex.Money, Is.EqualTo(result));
        }

    }
}
