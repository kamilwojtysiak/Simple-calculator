using System;
using Calculator.Enum;


namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double number1 = 10;
            double number2 = 5;

            Operation operation = Operation.Division;

            IOperations typeOfCalculation = typeOfCalculationFactory.GetCalculation(operation);

            Calculator context = new Calculator(typeOfCalculation);

            Console.WriteLine("Wynik = " + context.Calculate(number1, number2));
        }
    }
}
