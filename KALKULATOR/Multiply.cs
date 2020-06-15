using System;
using System.Collections.Generic;
using System.Text;

namespace KALKULATOR
{
    class Multiply
    {
        public void Calculate()
        {
            Console.WriteLine("Please enter numbers that you want to multiply.");

            Console.Write("NUMBER 1: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("NUMBER 2: ");

            double b = double.Parse(Console.ReadLine());

            double result = a * b;

            Console.WriteLine($"{a}*{b}= {result}");
            Console.ReadLine();
        }
    }
}
