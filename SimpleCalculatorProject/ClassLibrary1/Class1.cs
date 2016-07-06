using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
       
        public double GetNumber1(string numero1)
        {         
            
            double input1 = double.Parse(numero1);//number1);
            return input1;
        }
        public double GetNumber2(string numero2)
        {           
            
            double input2 = double.Parse(numero2);//number2);
            return input2;
        }
        public string Sign(string symbol)
        {
            string plussign = "+";
            string minussign = "-";

           
            if(symbol == "+")
            {
                return plussign;
            }
            else if (symbol == "-")
            {
                return minussign;
            }
            return symbol;
        }
        public double Calculations(double num1, double num2, string sign)
        {
            double sum = 0;
            double subs = 0;
            
            sum = num1 + num2;
            subs = num1 - num2;

            if(Sign(sign) == "+")
            {
                return sum;
            }
            else 
            {                
                return subs;
            }

           

        }
        
        
       
       
       
        
        
    }
}
           
           
           
           



