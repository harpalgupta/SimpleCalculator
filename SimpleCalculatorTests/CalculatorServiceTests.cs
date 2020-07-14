using FakeItEasy;
using NUnit.Framework;
using SimpleCalculator.Interfaces;
using SimpleCalculator.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorTests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private CalculatorService _calculatorService;
        private IAdditionService fakeAdditionService;
        private IMultiplicationService fakeMultiplicationService;

        [OneTimeSetUp]
        public void Setup()
        {
            //use interfaces mock Addition and Multiplication Service
             fakeAdditionService = A.Fake<IAdditionService>();
             fakeMultiplicationService = A.Fake<IMultiplicationService>();

            _calculatorService = new CalculatorService(fakeAdditionService, fakeMultiplicationService);
        }
        [Test]
        public void GivenAnAdditionLine_WithZeroPlusOne_ExpectAdditonMethodCalledWithZeroAndOne()
        {
            //Arrange
            var firstNumber = 0;
            var secondNumber = 1;

            //Act
            var result = _calculatorService.Calculate('+', firstNumber, secondNumber);

            //Assert
            //check there is a call to the addition service add method with correct first number and second number
            A.CallTo(() => fakeAdditionService.Add(firstNumber, secondNumber)).MustHaveHappenedOnceExactly();

        }

        [Test]
        public void GivenAnSubtractLine_WithThreeMinussOne_ExpectThrowThisCalculationMethodDoesNotExist()
        {
            //Arrange
            var firstNumber = 3;
            var secondNumber = 1;

            //Assert
            Assert.Throws<ArgumentException>(()=> _calculatorService.Calculate('-', firstNumber, secondNumber));



            //check there is a call to the addition service add method with correct first number and second number
            A.CallTo(() => fakeAdditionService.Add(firstNumber, secondNumber)).MustNotHaveHappened();

        }
    }
}
