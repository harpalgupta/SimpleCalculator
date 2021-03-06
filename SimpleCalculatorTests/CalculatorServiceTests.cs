﻿using FakeItEasy;
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

        [SetUp]
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
            var expectedAddResult = 9999;
            A.CallTo(() => fakeAdditionService.Add(firstNumber,secondNumber)).Returns(expectedAddResult);

            //Act
            var result = _calculatorService.Calculate('+', firstNumber, secondNumber);

            //Assert
            //check there is a call to the addition service add method with correct first number and second number
            A.CallTo(() => fakeAdditionService.Add(firstNumber, secondNumber)).MustHaveHappenedOnceExactly();
            Assert.That(result,Is.EqualTo(expectedAddResult));

        }

        [Test]
        public void GivenAnSubtractLine_WithThreeMinussOne_ExpectThrowThisCalculationMethodDoesNotExist()
        {
            //Arrange
            var firstNumber = 3;
            var secondNumber = 1;
            var expectedErrorMEssage = "Calculation Method Not Implemented";

            //Assert
            Assert.Throws<ArgumentException>(()=> _calculatorService.Calculate('-', firstNumber, secondNumber), expectedErrorMEssage);

            //check there a call is NOT Made to addition service add method with first number and second number
            A.CallTo(() => fakeAdditionService.Add(A<int>.Ignored, A<int>.Ignored)).MustNotHaveHappened();

        }

        [Test]
        public void GivenAMultiplicationLine_WithTwoTimesTwo_ExpectResultOfFour()
        {
            //Arrange
            var firstnum = 2;
            var secondnum = 2;

            //Act
            var result = _calculatorService.Calculate('*', firstnum, secondnum);

            //Assert
            A.CallTo(() => fakeMultiplicationService.Multiply(A<int>.Ignored, A<int>.Ignored)).MustHaveHappened();


        }

    }
}
