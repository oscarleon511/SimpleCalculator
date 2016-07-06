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
            double input1 = numbers.GetNumber1();
            Console.WriteLine("Please enter second number");
             double input2 = numbers.GetNumber2();
            Console.WriteLine("Please enter + to add or - to substract");
            string symbolentered = numbers.Sign();
            double calcs = numbers.Calculations(input1, input2);
            Console.WriteLine("This is your total: {0} {1} {2} = {3}", input1, symbolentered, input2, calcs);
            Console.ReadLine();
            
      

        
           
        }
    }
}
