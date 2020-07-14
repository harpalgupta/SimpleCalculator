using NUnit.Framework;
using SimpleCalculator.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorTests
{
    [TestFixture]
    public class MultiplicationServiceTests
    {
        private MultiplicationService _multiplicationService;

        [OneTimeSetUp]
        public void Setup()
        {
            _multiplicationService =new MultiplicationService();
        }
        [Test]
        public void GivenZeroInFirstNumberOrSecondNumber_WhenMultiplyIsCalled_ThenExpectResultTobeZero()
        {
            //Arrange Test
            var expectedResult = 0;

            //Act
            var result = _multiplicationService.Multiply(0, 1);

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }

        [Test]
        public void GivenTwoInFirstNumberAndThreeInSecondNumber_WhenMultiplyIsCalled_ThenExpectResultTobeSix()
        {
            //Arrange Test
            var expectedResult = 6;

            //Act
            var result = _multiplicationService.Multiply(2, 3);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
