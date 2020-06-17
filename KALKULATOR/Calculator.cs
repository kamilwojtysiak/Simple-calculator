using Calculator.Enum;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace Calculator
{
    public class Calculator
    {
        private IOperation _operation;

        public Calculator()
        {}

        public Calculator(IOperation operation)
        {
            _operation = operation;
        }

        public double Calculate(double number1, double number2)
        {
            return _operation.Calculate(number1, number2);
        }

        public IEnumerable<Type> GetOperations()
        {
            //var assembly = this.GetType().GetTypeInfo().Assembly;
            //var iDisposableAssemblies = assembly.DefinedTypes.Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(IOperation))).ToList();

            Type type = typeof(IOperation);

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            IEnumerable<Type> operations = types.Where(t => t.GetInterfaces().Contains(type));

            foreach (Type operation in operations)
            {
                Console.WriteLine(operation.Name);
            }

            return operations;
        }

        public IOperation GetOperation(string operationName)
        {
            IOperation operation = null;

            return operation;
        }
    }
}
