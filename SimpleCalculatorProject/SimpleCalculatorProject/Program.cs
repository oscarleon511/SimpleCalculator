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

            numbers.GetNumber1();
            numbers.Sign();
            numbers.GetNumber2();
            Console.WriteLine("This is the total of {0} {1} {2} = {3}", numbers.num1, numbers.oper, numbers.num2, numbers.Calculations());
            Console.ReadLine();
       
        }
    }
}
