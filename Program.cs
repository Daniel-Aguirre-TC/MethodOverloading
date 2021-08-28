using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 5));
            Console.WriteLine(Add(2, 5, true));
            Console.WriteLine(Add(2.40, 3.7));
        }

        // Add() with two int params.
        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        // Add() with two double params.
        static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        // Add() with two int params and a bool
        static string Add(int numOne, int numTwo, bool isDollars)
        {      
            // if bool is true
            if (isDollars)
            {
                // store sum
                int sum = numOne + numTwo;
                // return sum + "dollars" or "dollar"
                return sum + (sum > 1 ? " dollars" : "dollar");
            }
            // if bool is not true, just return a string stating the sum.
            else return Add(numOne, numTwo).ToString();
        }

    }
}
