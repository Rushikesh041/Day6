using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problems
{
    public class PrimeNumber
    {
        public int No;

        public PrimeNumber(int prime)
        {
            this.No = prime;
        }
        public static PrimeNumber UserInputForPrimeNumber()
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not : ");
            int pn = Convert.ToInt32(Console.ReadLine());

            return new PrimeNumber(pn)
            {
                No = pn
            };
        }
        public void CheckPrimeNumber()
        {
            int flag = 0;
            for (int i = 2; i <= (No - 1); i++)
            {
                if (No % i == 0)
                {
                    Console.WriteLine(No + " is not Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(No + " is Prime Number");
            }
        }
    }
}
