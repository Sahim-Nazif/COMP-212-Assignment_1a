using System;
/*
 * Assignment 1a 
 * COMP 212
 * Winter 2020
 * Multicast Delegate
 */
namespace Assignment_1a
{
    //declaring delegate
    public delegate void CalculateDel(double a, double b);
    class Program:Calculator
    {
        static void Main(string[] args)
        {
            CalculateDel addDel, subDel, multiDel, divDel;

            addDel = new CalculateDel(Add);
            subDel = new CalculateDel(Subtract);
            multiDel = new CalculateDel(Multiply);
            divDel = new CalculateDel(Divide);

            double a=1,b;

            while (a != -1)
            {
                Console.WriteLine("\nWelcome Centennial College Multicast Delegate Application");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\n Please enter the first double number or -1 to discontinue");
                a = double.Parse(Console.ReadLine());

                if(a==0)
                {
                    
                    Console.WriteLine("The value which you have entered is not valid for division . Please enter a value except Zero");
                    continue;
                }
                if(a==-1)
                {
                    Console.WriteLine("You have decided to quite the Centennial College Multicast Delegate Application.... " +
                        "\nBye for now !");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Please enter the second double number ");
                b = double.Parse(Console.ReadLine());

                addDel(a, b);
                subDel(a, b);
                multiDel(a, b);
                divDel(a, b);
            }
        }
    }
}
