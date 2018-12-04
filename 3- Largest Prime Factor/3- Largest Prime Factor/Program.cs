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
            const long number = 600851475143;
            double currentNum = 
                Convert.ToInt32(Math.Sqrt(600851475143) + 1);     
            long largestFact = 3;                                                 
            int newFact = 3;                  

            while (currentNum > 1)
            {
                // any prime factor cannot be even
                if (newFact%2 == 0)
                {
                    newFact++;
                }

                else if (currentNum%newFact == 0)
                {
                    currentNum = currentNum/newFact;

                    if(newFact>largestFact)
                    {
                        largestFact = newFact;
                    }
                }
                
            }

            Console.WriteLine("The largest prime factor of " 
                + number + " is " + largestFact + ".");
            Console.ReadLine();
        }
    }
}
