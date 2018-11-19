using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Multi_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////
            /// If we list all the natural numbers below 10 that are   ///
            /// multiples of 3 or 5, we get 3, 5, 6 and 9.             ///
            /// The sum of these multiples is 23.                      ///
            ///                                                        ///
            /// Find the sum of all the multiples of 3 or 5 below 1000 ///
            ///                                                        ///
            /// Written by Jessica Luk-Maduro on 19-11-2018            ///
            //////////////////////////////////////////////////////////////

            string userChoice;
            int maxNum = 1000;
            int currentMulti = 0;
            int sumOfMulti = 0;
            int remainderNum = 0;
            int displaySumOfMulti = 0;

            Console.WriteLine("For which value would you like to calculate the sum of all multiples "
                + "below 1000?");

            userChoice = Console.ReadLine();
            currentMulti = Convert.ToInt32(userChoice);

            // This will calculate the sum of all multiples

            for (int currentNum = currentMulti; currentNum < maxNum; currentNum += currentMulti)
            {
                remainderNum = (maxNum-1) % currentNum;
                sumOfMulti += currentNum;
            }

            // I chose to keep my operational and display value separate

            displaySumOfMulti = sumOfMulti;
            Console.WriteLine(displaySumOfMulti);

            Console.ReadLine();
        }
    }
    
}