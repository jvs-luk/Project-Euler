using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////
            /// The prime factors of 13195 are 5, 7, 13 and 29.                ///
            ///                                                                ///
            /// What is the largest prime factor of the number 600851475143?   ///
            ///                                                                ///
            /// Written by Jessica Luk-Maduro on 03-12-2018                    ///
            //////////////////////////////////////////////////////////////////////

            const long number = 600851475143;
            double currentNum = Convert.ToInt32(Math.Sqrt(600851475143) + 1);     // we only need to check numbers up 
            long largestFact = 0;                                                 // to the square root to find primes
            int newFact = 3;                  // 3 is the smallest prime number

            while (currentNum > 1)
            {
                // first check if number is divisible by 2; any prime factor should not be
                if (newFact%2 == 0 || currentNum%newFact > 0)
                {
                    newFact++;
                }

                // get factors of currentNum
                else if(currentNum%newFact == 0)
                {
                    currentNum = currentNum/newFact;  
                }

                // find largestFact
                if (largestFact == 0 || newFact > largestFact)
                {
                    largestFact = newFact;
                    Console.WriteLine(largestFact);
                }
            }

            Console.WriteLine("The largest prime factor of " + number + " is " + largestFact + ".");
            Console.ReadLine();
        }
    }
}
