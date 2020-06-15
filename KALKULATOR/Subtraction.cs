using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Subtraction
    {
        public void Calculate()
        {
            Console.WriteLine("Please enter numbers that you want to subtract.");
            Console.Write("NUMBER 1: ");

            double minuend = double.Parse(Console.ReadLine());

            Console.Write("NUMBER 2: ");

            double subtrahend = double.Parse(Console.ReadLine());

            double result = minuend - subtrahend;

            Console.WriteLine($"{minuend}-{subtrahend} = {result}");
            Console.ReadLine();
        }
    }
}
