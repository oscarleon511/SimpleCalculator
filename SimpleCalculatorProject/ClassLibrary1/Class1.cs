using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {

        public double num1 = 0;
        public double num2 = 0;
        public string oper = " ";
        public double total = 0;

        public void GetNumber1()
        {
            Console.WriteLine("Please enter number");
            string numero1 = Console.ReadLine();
            double input1 = double.Parse(numero1);
          
            num1 = input1;
        }
        public void GetNumber2()
        {
            Console.WriteLine("Please enter second number and press enter");
            string numero2 = Console.ReadLine();
            double input2 = double.Parse(numero2);
            num2 = input2;
        }
        public void Sign()
        {
            Console.WriteLine("Please enter + to add, - to substract, * to multiply or / to divide");
            string symbol = Console.ReadLine();
            oper = symbol;
           
        }
       
        public double Calculations()
        {
            double sum = 0;
            double subs = 0;
            double multiplication = 0;
            double division = 0;
            
            sum = num1 + num2;
            subs = num1 - num2;
            multiplication = num1 * num2;
            division = num1 / num2;

            if(oper == "+")
            {
                total = sum;
                return total;
            }
            else if(oper == "-")
            {                
                total = subs;
                return total;
            }
            else if(oper == "*")
            {
                total = multiplication;
                return total;
            }
            else if(oper == "/")
            {
                total = division;
                return total;
            }

            return total;
           

        }
        
        
       
       
       
        
        
    }
}
           
           
           
           



