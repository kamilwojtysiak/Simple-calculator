using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private IOperations _calculation;

        public Calculator(IOperations calculation)
        {
            _calculation = calculation;
        }

        public double Calculate(double number1, double number2)
        {
            return _calculation.Calculate(number1, number2);
        }
    }
}
