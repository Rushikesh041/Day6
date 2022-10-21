using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problems
{
    public class FibonacciSeries
    {
        public int Number;

        public FibonacciSeries(int number)
        {
            Number = number;
        }
        public static FibonacciSeries UserInputForFibonacciSeries()
        {
            Console.WriteLine("Enter the Number of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());

            return new FibonacciSeries(num)
            {
                Number = num
            };
        }
        public void CalculateFibonacciSeries()
        {
            int num1 = 0, num2 = 1, num3;
            Console.Write("Fibonacci Series is : ");
            for (int i = 2; i <= Number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}