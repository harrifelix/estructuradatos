using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Video4
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(10));
        }

        private static int factorial(int v)
        {
            int r = 0;

            //Caso Inductivo
            if (v > 1)
            {
                r = v * factorial(v - 1);
            }
            //Caso Base
            if (v == 1 || v == 0)
            {
                r = 1;
            }
            return r;
        }
    }
}
