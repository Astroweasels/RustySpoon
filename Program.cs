using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        // Arrays put here to under public static so that it could be in scope for the Main method as well as PrintArrays Method
        public static long[] baseNumbers = new long[4];
        public static long[] exponents = new long[4];
        public static long[] results = new long[4];

        static void Main(string[] args)
        {
            // Declared variables
            Random RNG = new Random();            
            // Filling the buckets
            for (int i = 0; i < 5; i++)
              {
                int x = RNG.Next(1, 50);
                int y = RNG.Next(1, 10);               
              }
            // Passing the power method through the arrays
            for(int i = 0; i < 5; i++)
              {
                Power (baseNumbers[i], exponents[i]);
                
              }
           
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
       // Methods
        public static long Power (long number, long exponent)
            {
                if(number == 1)
                  {
                      return 1;
                  }
                else
                  {
                return number * Power(number, exponent - 1);
                  }
            }
        public static void PrintArrays ()
        {
            Console.WriteLine("Base    Exponent    Result");
            for (int i = baseNumbers.GetLowerBound(0); i < baseNumbers.GetUpperBound(-1); i++)
            {
                Console.WriteLine(baseNumbers[4]);
                Console.WriteLine(exponents[4]);
                Console.WriteLine(results[4]);
            }
                
        }
    }
}
