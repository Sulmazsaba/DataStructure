using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
   public class Recursion
    {
        public void Calculate(int n)
        {
            if (n>0)
            {
                Console.WriteLine(n*n);
                Calculate(n-1);
            }
        }

        public BigInteger Factorial(int n)
        {
            if (n > 0)
            {
                return n * Factorial(n - 1);
               
            }

            return 1;
        }
    }
}
