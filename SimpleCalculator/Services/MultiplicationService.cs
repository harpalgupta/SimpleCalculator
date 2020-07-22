using System;
using SimpleCalculator.Interfaces;

namespace SimpleCalculator.Services
{
    public class MultiplicationService : IMultiplicationService
    {
        public int Multiply(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0)
            {
                throw new ArgumentException("expected positive input");
            }
            return firstNumber * secondNumber;
        }

        public string SomeOtherMethod()
        {
            return "";
        }
    }
}
