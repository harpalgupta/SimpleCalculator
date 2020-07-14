using NUnit.Framework;
using SimpleCalculator.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorTests
{
    [TestFixture]
    public class AdditionServiceTests
    {
        private AdditionService _additionService;

        //As a simpleCalculator User When I submit a line with 2 numbers with a calculation containing a plus sign the user expects the sum of both numbers returned

        [OneTimeSetUp]
        public void Setup()
        {
            //define service once to test
             _additionService = new AdditionService();


        }

        [Test]
        public void GivenZeroPlusZero_WhenAddCalled_ThenExpectResultReturnedToBeZero()
        {
            //Arrange
            var expectedResult = 0;
            //Act
            //get result
            var result = _additionService.Add(0,0);

            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenOnePlusOne_WhenAddCalled_ThenExpectTwoToBeReturned()
        {
            //Arrange
            var expectedResult = 2;
            //Act
            //get result
            var result = _additionService.Add(1, 1);

            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));
        }




    }
}
