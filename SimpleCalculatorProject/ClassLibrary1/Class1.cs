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
            
            double input1 = double.Parse(numero1);
            return input1;
        }
        public double GetNumber2(string numero2)
        {           
            
            double input2 = double.Parse(numero2);
            return input2;
        }
        public string Sign(string symbol)
        {
            string plussign = "+";
            string minussign = "-";
            string multisign = "*";
            string divisign = "/";

           
            if(symbol == "+")
            {
                return plussign;
            }
            else if (symbol == "-")
            {
                return minussign;
            }
            else if (symbol == "*")
            {
                return multisign;
            }
            else if (symbol == "/")
            {
                return divisign;
            }
            return symbol;
        }
       
        public double Calculations(double num1, double num2, string sign)
        {
            double sum = 0;
            double subs = 0;
            double multiplication = 0;
            double division = 0;
            
            sum = num1 + num2;
            subs = num1 - num2;
            multiplication = num1 * num2;
            division = num1 / num2;

            if(Sign(sign) == "+")
            {
                return sum;
            }
            else if(Sign(sign) == "-")
            {                
                return subs;
            }
            else if(Sign(sign)== "*")
            {
                return multiplication;
            }
            else if(Sign(sign)== "/")
            {
                return division;
            }

            else
            {
                return num1;//throw new Exception("Please try again!!");
            }

           

        }
        
        
       
       
       
        
        
    }
}
           
           
           
           



