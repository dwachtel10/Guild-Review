using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user for an integer.  Make sure they enter a valid integer!
        /// 
        /// See the String Input lesson for TryParse() examples
        /// </summary>
        /// <returns>the user input as an integer</returns>
        static int GetNumberFromUser()
        {
            int output;
            while (true)
            { 
            
            Console.WriteLine("Please enter a number.");
            string input = Console.ReadLine();
            if (int.TryParse(input, out output))
            {
                break;
            }
            else
            {
                Console.WriteLine("Not a number!");
            }
                
        }
            return output;
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {
            for (int i = 1; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
            if (factors.Sum() == number)
            { Console.WriteLine($"{number} is a perfect number!"); }
            else
            { Console.WriteLine($"{number} is not a perfect number.  Sorry!"); }
        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
            if (factors.Count == 1)
            {
                Console.WriteLine($"{number} is a prime number!");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.  Better luck next time!");
            }
        }
    }
}
