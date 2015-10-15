using System;
using System.Text;

namespace MySpace
{
    internal class PrimeNumber
    {
        private string v;
        private int number;
        private bool isInteger;  //TODO should this be BOOLEAN class?

        static private int firstPrime = 2;

        public PrimeNumber()
        {
            isInteger = false;
        }

        public PrimeNumber(int input)
        {
            number = input;
            isInteger = true;
        }

        public PrimeNumber(String input)
        {
            v = input;
            isInteger = int.TryParse(input, out number);
        }

        public bool IsInteger()
        {
            return isInteger;
        }

        public bool IsPrime()
        {
            // TODO, should this give an error or message about why a particular case is not prime ?

            // Check to see if it fails tests for a prime number, if it passes them all then it is a prime number


            // Check non-factor cases
            // must be an integer
            if (!IsInteger())
            {
                return false;
            }

            // use a switch statement ???
            // could do <= 1 but... each is a special case           
            if (number < 0)
            {
                return false;
            }
            if (number == 0)
            {
                return false;
            }
            if (number == 1)
            {
                return false;
            }

            // look to see if it has a factor
            for (int i = firstPrime; i < number; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;  // if gets here then it must be a prime.
        }

        public String display()
        {
            //TODO use StringBuilder ???
            // StringBuilder output = new StringBuilder(); 
            // couldn't get Stringbuilder to work right.... 
            String output;

            // yeah, you are probably not going to like this...

            output = (IsInteger() ? number.ToString() : v) + " is";

            if (!IsInteger())  // yeah, maybe should have used nest ternary opperator....
            {
                output = output + " not an integer";
            }
            else output = output + (this.IsPrime() ? " Prime" : " NOT prime");

            //return output.ToString();
            return output;
        }

    }


}