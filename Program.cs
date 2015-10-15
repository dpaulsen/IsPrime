using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySpace
{

    class Program
    {

        /// <summary>
        /// This program checks if a number entered to the commandline is a prime number or not.
        /// A prime number only has factors 1 and itself. 
        /// A prime must also be a natural number (i.e. no: decimals, fractions or negatives or zero), also 1 is not prime.         
        /// </summary>


        static void Main(string[] args)
        {
            // set input....
            if (args.Count() == 0)
            {
                Console.Write("I need a number to check");
            }
            else
            {
                PrimeNumber numberToCheck = new PrimeNumber(args[0]);
                Console.WriteLine(numberToCheck.display());
            }

            return;

        }
    }
}