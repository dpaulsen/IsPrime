using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PrimeNumberTests
{

        [TestClass]
        public class TestPrimes
        {
           // private PrimeNumber prime;  //namespace...


            [TestMethod]
            public void TestMethod1()
            {
            PrimeNumber numberToCheck = new PrimeNumber("foo");

            Assert(numberToCheck.isInteger() != true);
        }
        }

    
}
