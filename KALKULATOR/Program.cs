﻿using System;
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
                Console.WriteLine("select operation");

                foreach (var operation in operations)
                {
                    Console.WriteLine(operation.GetName());
                }

                string userInput = Console.ReadLine();

                choosenOperation = operations.SingleOrDefault(o => o.GetName() == userInput);

                if (choosenOperation == null)
                {
                    Console.WriteLine("zła nazwa");
                }      
            } while (choosenOperation == null);

            Console.WriteLine(choosenOperation.Calculate(10, 2));
        }
    }
}
