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
            double input1 = numbers.GetNumber1(number1);
            Console.WriteLine("Please enter second number");
            string number2 = Console.ReadLine();
            double input2 = numbers.GetNumber2(number2);
            Console.WriteLine("Please enter + to add or - to substract");
            string symbol = Console.ReadLine();
            string symbolentered = numbers.Sign(symbol);
            double calcs = numbers.Calculations(input1, input2, symbolentered);
            Console.WriteLine("This is your total: {0} {1} {2} = {3}", input1, symbolentered, input2, calcs);
            Console.ReadLine();
            
      

        
           
        }
    }
}
