using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1a
{
   public class Calculator
    {
        public static void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("The result of addition is : " + result );
        }

        public  static void Subtract (double a, double b)
        {
            double result = a - b;
            if (a < b)
            {
                Console.WriteLine("First number can not be less than second number !");
            }
            else
            {
                Console.WriteLine("The result of subtraction is : " + result);
            }
        }
        public static void Multiply (double a, double b)
        {
            double result = a * b;
            Console.WriteLine("The result of multipication is : " + result);
        }

        public static void Divide (double a, double b )
        {
            if (a==0)
            {
                Console.WriteLine("The value which you have entered is not valid for division . Please enter a value except Zero");
            }
            else
            {
                double result = (a / b);
                Console.WriteLine("The result of division is : " + result);
            }
        }
    }
}
