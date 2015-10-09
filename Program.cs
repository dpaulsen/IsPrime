using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
