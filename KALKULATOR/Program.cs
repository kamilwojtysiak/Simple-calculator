using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in my calculator \nPress enter to begin.");
            Console.ReadLine();
            Console.WriteLine("What opertaion you want to do? \n1.ADDING \n2.SUBTRACTION \n3.MULTIPLY \n4.DIVISION");
            Console.Write("Choose  number and press 'enter': ");

            int userChoice = int.Parse(Console.ReadLine());  

            switch (userChoice)
            {
                case 1:
                    Addition addition = new Addition();
                    addition.Calculate();
                    break;
                case 2:
                    Subtraction subtraction = new Subtraction();
                    subtraction.Calculate();
                    break;
                case 3:
                    Multiply multiply = new Multiply();
                    multiply.Calculate();
                    break;
                case 4:
                    Division division = new Division();
                    division.Calculate();
                    break;
            }
        }
    }
}
