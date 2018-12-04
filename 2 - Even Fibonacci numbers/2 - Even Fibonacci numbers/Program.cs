using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibNum = 1;
            int firstPrevFibNum = 1;
            int secondPrevFibNum = 0;
            int sumFibNum = 0;
            int evenCheck = 0;

            while (fibNum < 4000000)
            {
                fibNum = firstPrevFibNum + secondPrevFibNum;

                // check whether the fibNum is even or not
                evenCheck = fibNum % 2;

                if (evenCheck == 0)
                {
                    sumFibNum += fibNum;
                }

                // storing current fibNums to correctly 
                // increase the fibNum in the next loop
                secondPrevFibNum = firstPrevFibNum;
                firstPrevFibNum = fibNum;
            }

            Console.WriteLine(sumFibNum);
            Console.ReadLine();
        }
    }
}
