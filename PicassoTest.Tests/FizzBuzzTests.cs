using NUnit.Framework;
using System;

namespace PicassoTest.Tests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void getOutput_ReturnsFizzBuzz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = 15;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void getOutput_NumberIsNegagtive_ReturnsFizzBuzz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = -15;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void getOutput_ReturnsFizz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = 9;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void getOutput_NumberIsNegative_ReturnsFizz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = -9;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void getOutput_ReturnsBuzz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = 10;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void getOutput_NumberIsNegative_ReturnsBuzz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = -10;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void getOutput_ReturnsNumber()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = 7;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

        [Test]
        public void getOutput_NumberIsNegative_ReturnsNumber()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = -7;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

        [Test]
        public void getOutput_NumberIs0_ReturnsFizzBuzz()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = 0;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void getOutput_NumberIsMax_ReturnsNumber()
        {
            //Arrange
            var fz = new FizzBuzz();
            var number = Int32.MaxValue;

            //Act
            var result = fz.GetOutput(number);

            //Assert
            Assert.That(result, Is.EqualTo(number.ToString()));
        }



    }
}
