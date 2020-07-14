using SimpleCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IAdditionService additionService;
        private readonly IMultiplicationService multiplicationService;

        public CalculatorService(IAdditionService additionService, IMultiplicationService multiplicationService)
        {
            this.additionService = additionService;
            this.multiplicationService = multiplicationService;
        }
        public int Calculate(char sign, int firstNumber, int secondNumber)
        {
            if (sign== '+')
            {
                return additionService.Add(firstNumber, secondNumber);

            }
            throw new ArgumentException("Calculation Method Not Implemented");
        }
    }
}
