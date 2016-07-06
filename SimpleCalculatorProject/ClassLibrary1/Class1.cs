using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
       
        public double GetNumber1()
        {         
            string number1 = Console.ReadLine();
            double input1 = double.Parse(number1);
            return input1;
        }
        public double GetNumber2()
        {           
            string number2 = Console.ReadLine();
            double input2 = double.Parse(number2);
            return input2;
        }
        public string Sign()
        {
            string symbol = Console.ReadLine();
            return symbol;
        }
        public double Calculations(double num1, double num2)
        {
            double sum = 0;
            double subs = 0;
            
            sum = num1 + num2;
            subs = num1 - num2;

            if(Sign() == "+")
            {
                return sum;
            }
            else //if (Sign() == "-")
            {                
                return subs;
            }

           

        }
        
        
       
       
       
        
        
    }
}
           
           
           
           



