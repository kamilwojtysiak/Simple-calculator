using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private IOperation _operation;

        public Calculator(IOperation operation)
        {
            _operation = operation;
        }

        public double Calculate(double number1, double number2)
        {
            return _operation.Calculate(number1, number2);
        }

        public IList<IOperation> GetOperations()
        {

        }

        public IOperation GetOperation(string operationName)
        {

        }
    }
}
