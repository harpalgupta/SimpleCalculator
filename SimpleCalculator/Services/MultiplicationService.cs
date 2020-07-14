using SimpleCalculator.Interfaces;

namespace SimpleCalculator.Services
{
    public class MultiplicationService : IMultiplicationService
    {
        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public string SomeOtherMethod()
        {
            return "";
        }
    }
}
