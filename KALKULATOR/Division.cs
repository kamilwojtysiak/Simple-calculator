using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Division
    {
        public void Calculate()
        {
            Console.WriteLine("Please enter numbers that you want to division.");
            Console.Write("NUMBER 1: ");

            double dividend = double.Parse(Console.ReadLine());

            Console.Write("NUMBER 2: ");

            double divider = double.Parse(Console.ReadLine());

            double result = dividend / divider;

            Console.WriteLine($"{dividend}/{divider} = {result}");
            Console.ReadLine();
        }
    }
}
