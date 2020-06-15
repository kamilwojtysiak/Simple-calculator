using System;

namespace KALKULATOR
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
                    Adding a = new Adding();
                    a.Calculate();
                    break;
                case 2:
                    Subtraction s = new Subtraction();
                    s.Calculate();
                    break;
                case 3:
                    Multiply m = new Multiply();
                    m.Calculate();
                    break;
                case 4:
                    Division d = new Division();
                    d.Calculate();
                    break;
            }
        }
    }
}
