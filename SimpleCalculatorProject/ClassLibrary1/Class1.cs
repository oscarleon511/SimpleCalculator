using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
        public void Calculations(double num1, string oper, double num2)
        {
            double solution = 0;
            switch(oper)
            {
                case "+":
                    solution = num1 + num2;
                    
                    break;
                case "-":
                    solution = num1 - num2;
                    break;
                case "*":
                    solution = num1 *num2;
                    break;
                case "/":
                    solution = num1 / num2;
                    break;
                    
            }
            //return solution;
            Console.WriteLine("Your answer is " + solution);
            Console.WriteLine("Do you want to continue?");
            string answer = Console.ReadLine();
            string answerconverted = answer.ToLower();
            if (answerconverted == "yes")
            {
                ContinuedCalculations(solution);
            }
            else
            {
                Console.WriteLine("Thank you for participating");
            }
        }
           public void Questions()
        {
            Console.WriteLine("Please enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please pick an operator + to add, - to sub, * to multiply and / to divide");
            string oper = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            double num2 = double.Parse(Console.ReadLine());
            Calculations(num1,oper, num2);
            
        }
        public void ContinuedCalculations(double result)
           {
               Console.WriteLine("Your answer was " + result);
               Console.WriteLine("What is your operator?");
               string oper = Console.ReadLine();
               Console.WriteLine("Pick your second number");
               double num2 = double.Parse(Console.ReadLine());

               Calculations(result, oper, num2);
           }

       

    }
       
  }


           
           
           
           



