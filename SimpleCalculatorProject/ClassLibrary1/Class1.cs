using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {

        public double savednum1 = 0;
        public double savednum2 = 0;
        public string savedoper = string.Empty;
       

        public void GetNumber1(string number1)
        {
                    
            double input1 = double.Parse(number1);
          
            savednum1 = input1;
        }
        public void GetNumber2(string number2)
        {
            
            double input2 = double.Parse(number2);
            savednum2 = input2;
        }
        public void Sign(string symbol)
        {
            
            savedoper = symbol;
           
        }
       
        public double Calculations()
        {
            double sum = 0;
            double subs = 0;
            double multiplication = 0;
            double division = 0;
            double total = 0;
            
            sum = savednum1 + savednum2;
            subs = savednum1 - savednum2;
            multiplication = savednum1 * savednum2;
            division = savednum1 / savednum2;

            if(savedoper == "+")
            {
                total = sum;
                return total;
                
            }
            else if (savedoper == "-")
            {                
                total = subs;
                return total;
                
            }
            else if(savedoper == "*")
            {
                total = multiplication;
                return total;
                
            }
            else if(savedoper == "/")
            {
                total = division;
                return total;
                
            }


            return total;

        }
        
        
       
       
       
        
        
    }
}
           
           
           
           



