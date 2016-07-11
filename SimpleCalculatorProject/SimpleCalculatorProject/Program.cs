using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace SimpleCalculatorProject
{
     class Program
    {
        static void Main(string[] args)
        {
            Class1 numbers = new Class1();
            Console.WriteLine("Please enter number");
            string number1 = Console.ReadLine();
            numbers.GetNumber1(number1);

            Console.WriteLine("Please enter + to add, - to substract, * to multiply or / to divide");
            string symbol = Console.ReadLine();
            numbers.Sign(symbol);

            Console.WriteLine("Please enter second number and press enter");
            string number2 = Console.ReadLine();
            numbers.GetNumber2(number2);


            double result = numbers.Calculations();
            Console.WriteLine("This is your total for {0} {1} {2} = {3}", number1,symbol, number2, result );
            Console.ReadLine();

            
       
        }
    }
}
