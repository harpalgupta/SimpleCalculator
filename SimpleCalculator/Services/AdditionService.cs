﻿using SimpleCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Services
{
    public class AdditionService : IAdditionService
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string SomeOtherMethod()
        {
            return "SomeOtherMethod";
                
         }
    }


}
