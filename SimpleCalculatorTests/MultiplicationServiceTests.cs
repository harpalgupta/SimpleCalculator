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
            Assert.That(result, Is.EqualTo(expectedResult));

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
            Assert.That(result.GetType(),Is.EqualTo(typeof(int)));

        }

        [Test]
        public void GivenANegativeInput_WhenMultiplyIsCalled_ThenExpectThrow()
        {
            //Arrange
            var negativeInput1 = -30;

            //Act Assert

            Assert.Throws<ArgumentException>(()=>_multiplicationService.Multiply(negativeInput1, 12));


        }
    }
}
