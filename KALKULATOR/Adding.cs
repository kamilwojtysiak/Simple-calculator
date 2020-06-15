using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Addition
    {
        public void Calculate()
        {
            Console.WriteLine("Please enter numbers that you want to add.");
            Console.Write("NUMBER 1: ");

            double number1 = double.Parse(Console.ReadLine());

            Console.Write("NUMBER 2: ");

            double number2 = double.Parse(Console.ReadLine());

            double result = number1 + number2;

            Console.WriteLine($"{number1}+{number2} = {result}");
            Console.ReadLine();
        }
    }
}
