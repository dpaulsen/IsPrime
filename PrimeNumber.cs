using System;
using System.Text;

public class PrimeNumber

{
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
       isInteger = int.TryParse(input, number);
    }

    public bool IsInteger()
    {
        return isInteger;
    }

    public bool isPrime()
    {
        // use a switch statement ???

        // could do <= 1 but... each is a specialcase

        if (number < 0) return false;
        if (number == 0) return false;
        if (number == 1) return false;  

        for(int i = firstPrime; i < number; ++i)
        {
            if (number % i == 0) goto blackmagic; 
        }

        return true;

    blackmagic:
        return false;

    }

    public String display()
    {
        StringBuilder output;

        output = number.ToString + " is "; 

        // yeah you are probably not going to like this...
        if(!IsInteger()) { output = output + " not an integer"; } else output = output + isPrime() ? " Prime" : "not prime";

        return output.ToString();
    }

}
