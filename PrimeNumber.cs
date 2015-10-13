using System;
using System.Text;

namespace MySpace
{
    internal class PrimeNumber
    {
        private string v;
        private int number;
        private bool isInteger;  //should this be BOOLEAN class?

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

        public bool isPrime()
        {
            // TODO, should this give an error or message about why a particular case is not prime ?

            //need to get this out of my system.... makes me a little sad... *Soul has been Crushed a little bit*
            /*
            if (false)
            {
            blackmagic:
                return false;
            } 
            */
            
            // use a switch statement ???

            // could do <= 1 but... each is a special case

            // you think this is making you upset...
            if (number < 0) return false;
            if (number == 0) return false;
            if (number == 1) return false;

            for (int i = firstPrime; i < number; ++i)
            {
                if (number % i == 0) goto blackmagic;
                // now you realize the previous infraction was insignificant.
            }

            return true;

       blackmagic:
            return false;


        }

        public String display()
        {
            // StringBuilder output = new StringBuilder(); 
            // couldn't get Stringbuilder to work right.... 
            String output;

            // yeah, you are probably not going to like this...

            output = (IsInteger() ? number.ToString() : v ) + " is";

            if (!IsInteger())  // yeah, maybe should have used nest ternary opperator....
            {
                output = output + " not an integer";
            }
            else output = output + (this.isPrime() ? " Prime" : " NOT prime");

            //return output.ToString();
            return output;
        }

    }


}