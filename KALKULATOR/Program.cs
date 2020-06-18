using System;
using System.Reflection;
using Calculator.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            IList<IOperation> operations = calculator.GetOperations();

            IOperation choosenOperation;

            do
            {
                Console.WriteLine("Select operation:");

                foreach (var operation in operations)
                {
                    Console.WriteLine(operation.GetName());
                }

                Console.WriteLine();
                Console.Write("Operation name: ");

                string userInput = Console.ReadLine();

                choosenOperation = operations.SingleOrDefault(o => o.GetName() == userInput);

                if (choosenOperation == null)
                {
                    Console.WriteLine("Wrong name!");
                }      
            } while (choosenOperation == null);

            Console.WriteLine("Result: " + choosenOperation.Calculate(10, 2));
        }
    }
}
