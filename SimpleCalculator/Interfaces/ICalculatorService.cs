using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Interfaces
{
    public interface ICalculatorService
    {
        public int Calculate(char sign, int firstNumber, int secondNumber);
        
    }
}
