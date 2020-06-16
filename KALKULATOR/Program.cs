using System;
using System.Reflection;
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

            IOperation typeOfCalculation = typeOfCalculationFactory.GetCalculation(operation);

            Calculator calculator = new Calculator(typeOfCalculation);

            Console.WriteLine("Wynik = " + calculator.Calculate(number1, number2));
        }
    }
}
