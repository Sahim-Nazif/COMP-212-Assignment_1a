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

            double a = 0,b;

            while (a != -1)
            {
                Console.WriteLine("\nWelcome Centennial College Multicast Delegate Application");
                Console.WriteLine("\n Please enter the first double number or -1 to discontinue");
                a = double.Parse(Console.ReadLine());


            }
        }
    }
}
