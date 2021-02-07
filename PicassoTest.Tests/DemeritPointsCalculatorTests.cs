using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateDemeritPoints_Returns0()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            var speed = 60;
            //Act
            var result = calculator.CalculateDemeritPoints(speed);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_ReturnsDemeritPoints()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            var speed = 70;
            //Act
            var result = calculator.CalculateDemeritPoints(speed);

            const int kmPerDemeritPoint = 5;
            const int SpeedLimit = 65;
            var demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            //Assert
            Assert.That(result, Is.EqualTo(demeritPoints));
        }

        [Test]
        public void CalculateDemeritPoints_ReturnsArgumentOutOfRangeException()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            var speed = 301;
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }
        [Test]
        public void CalculateDemeritPoints_SpeedEqualsZero_ReturnsArgumentOutOfRangeException()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            var speed = 0;
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedNegative_ReturnsArgumentOutOfRangeException()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();
            var speed = -4;
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_MaxSpeed_ReturnsDemeritPoints()
        {
            //Arrange
            var speed = 300;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            //Act
            var result = calculator.CalculateDemeritPoints(speed);

            const int kmPerDemeritPoint = 5;
            const int SpeedLimit = 65;
            var demeritPoints = (speed - SpeedLimit) / kmPerDemeritPoint;

            //Assert
            Assert.That(result, Is.EqualTo(demeritPoints));
        }

    }
}
