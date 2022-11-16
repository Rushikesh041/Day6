using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problems
{
    public class PerfectNum
    {
        public int pNumber;

        public PerfectNum(int pNumber)
        {
            this.pNumber = pNumber;
        }
        public static PerfectNum UserInputForPerfectNumber()
        {
            Console.WriteLine("Enter the Number to Check Number is Perfect or Not : ");
            int n = Convert.ToInt32(Console.ReadLine());

            return new PerfectNum(n)
            {
                pNumber = n
            };
        }
        public void CheckPerfectNumber()
        {
            int sum = 0;

            for (int i = 1; i < pNumber; i++)
            {
                if (pNumber % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == pNumber)
            {
                Console.WriteLine(pNumber + " is Perfect Number ");
            }
            else
            {
                Console.WriteLine(pNumber + " is  Not a Perfect Number ");
            }
        }
    }
}
