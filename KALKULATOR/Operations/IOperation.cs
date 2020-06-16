using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IOperation
    {
        double Calculate(double number1, double number2);
    }
}
