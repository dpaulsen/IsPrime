using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    namespace IsPrime
    {
        class Program
        {
            public class PrimeNumber numberToCheck;

            /* a prime number only has factors 1 and itself 
               This program checks if a number entered to the commandline is a prime number or not
                */

            static void Main(string[] args)
            {
                numberToCheck = PrimeNumber(args[0]);
                /*  
                // yes this is an ugly way to remove this stuff....
                for ( int i =0; i < args.Count(); ++i)
                {
                    // there must be a better way/....
                    //Console.Write("i = %d ", i, " | args[i] = ", args[i]);
                    Console.Write("i = ");
                    Console.Write(i);
                    Console.Write(" | args[i] = ");
                    Console.Write(args[i]);
                    Console.WriteLine();
                }
                */


                // set input....
                int l;
                l = args.Count();
                if (l == 0)
                {
                    Console.Write("I need a number to check");
                    return;
                }
                int num;
                if (!int.TryParse(args[0], out num))
                {
                    Console.Write("The first input must be an integer.");
                    return;
                }

                // do simple checks
                if (num < 0)
                {
                    Console.Write("A prime nubmer can not be negative.");
                    return;
                }
                if (num == 0)
                {
                    Console.Write("Zero is not prime...");
                    return;
                }
                if (num == 1)
                {
                    Console.Write("One is not prime...");
                    return;
                }

                // Now actually checking for a prime number
                //naive solution; this is not going to be fast, and is going to check too many factors

                // TODO
                for (int i = 2; i < num; ++i)
                    if (num % i == 0)
                    {
                        Console.Write("The number entered: ");
                        Console.Write(num);
                        Console.Write(" is not prime.");
                        return;
                    }

                Console.Write("The number entered: ");
                Console.Write(num);
                Console.Write(" IS PRIME.");




                return;


            }
        }
    }
}
